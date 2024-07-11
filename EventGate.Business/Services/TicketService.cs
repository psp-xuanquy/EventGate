using EventGate.Business.Mappers;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventGate.Data.Repositories.Interface;
using EventGate.Business.Services.Interface;
using AutoMapper;
using EventGate.Data.Repositories;
using System.Drawing;
using System.Runtime.InteropServices;
using ZXing;
using ZXing.Common;
using System.Drawing.Imaging;
using EventGate.Business.Models.DTOs.Response;

namespace EventGate.Business.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly ISeatRepository _seatRepository;
        //private readonly IEventRepository _voucherRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, ISeatRepository seatRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _seatRepository = seatRepository;
            _mapper = mapper;
        }

        // Get all Ticket
        public async Task<List<TicketDTO>> GetAllTicketsAsync()
        {
            var tickets = await _ticketRepository.GetAllAsync();
            return _mapper.Map<List<TicketDTO>>(tickets);
        }

        // Get Ticket by ID
        public async Task<TicketResponseDTO> GetTicketByIdAsync(string ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            if (ticket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            var ticketResponse = _mapper.Map<TicketResponseDTO>(ticket);

            if (ticket.QRCode != null)
            {
                string qrCodeBase64 = Convert.ToBase64String(ticket.QRCode);

                // Set the base64 QR code string in the response DTO
                ticketResponse.QRCodeBase64 = qrCodeBase64;
            }

            return ticketResponse;
        }

        // Add Ticket
        public async Task<int> AddTicketAsync(string user, TicketDTO addTicketDto)
        {
            //var existingEvent = await _eventRepository.GetByIdAsync(addTicketDto.EventID);
            //if (existingEvent == null)
            //{
            //    throw new Exception($"Event with ID ( {addTicketDto.EventID} ) NOT FOUND.");
            //}

            var existingSeat = await _seatRepository.GetByIdAsync(addTicketDto.SeatID);
            if (existingSeat == null)
            {
                throw new Exception($"Seat with ID ( {addTicketDto.SeatID} ) NOT FOUND.");
            }

            if (await _ticketRepository.IsSeatAssociatedWithAnotherTicketAsync(addTicketDto.SeatID))
            {
                throw new Exception($"Seat with ID ( {addTicketDto.SeatID} ) is already ASSOCIATED with ANOTHER TICKET.");
            }

            // Generate QRCode from Ticket data
            var qrCodeImageBytes = GenerateQRCodeImage(addTicketDto);

            // Store as base64
            addTicketDto.QRCodeBase64 = Convert.ToBase64String(qrCodeImageBytes);

            var ticket = _mapper.Map<Ticket>(addTicketDto);
            ticket.QRCode = qrCodeImageBytes;
            return await _ticketRepository.AddAsync(user, ticket);
        }

        // Update Ticket
        public async Task<int> UpdateTicketAsync(string ticketId, TicketDTO updateTicketDto)
        {
            var existingTicket = await _ticketRepository.GetByIdAsync(ticketId);
            if (existingTicket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            //var existingEvent = await _eventRepository.GetByIdAsync(updateTicketDto.EventID);
            //if (existingEvent == null)
            //{
            //    throw new Exception($"Event with ID ( {updateTicketDto.EventID} ) NOT FOUND.");
            //}

            var existingSeat = await _seatRepository.GetByIdAsync(updateTicketDto.SeatID);
            if (existingSeat == null)
            {
                throw new Exception($"Seat with ID ( {updateTicketDto.SeatID} ) NOT FOUND.");
            }

            if (existingTicket.SeatID != updateTicketDto.SeatID &&
                await _ticketRepository.IsSeatAssociatedWithAnotherTicketAsync(updateTicketDto.SeatID))
            {
                throw new Exception($"Seat with ID ( {updateTicketDto.SeatID} ) is already ASSOCIATED with ANOTHER TICKET.");
            }

            // Generate QRCode from Ticket data
            var qrCodeImageBytes = GenerateQRCodeImage(updateTicketDto);

            // Store as base64
            updateTicketDto.QRCodeBase64 = Convert.ToBase64String(qrCodeImageBytes);

            var ticket = _mapper.Map<Ticket>(updateTicketDto);
            ticket.QRCode = qrCodeImageBytes;
            return await _ticketRepository.UpdateAsync( ticketId, ticket);
        }

        public async Task<int> UpdateQRCodeTicketAsync( string ticketId, string? QRCodeBase64)
        {
            var existingTicket = await _ticketRepository.GetByIdAsync(ticketId);
            if (existingTicket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            // Chuyển đổi mã QR từ Base64 sang mảng byte
            byte[] qrCodeBytes = null;
            if (!string.IsNullOrEmpty(QRCodeBase64))
            {
                qrCodeBytes = Convert.FromBase64String(QRCodeBase64);
            }

            // Cập nhật vé với mã QR đã chuyển đổi
            existingTicket.QRCode = qrCodeBytes;

            // Lưu thay đổi vào cơ sở dữ liệu
            return await _ticketRepository.UpdateAsync(ticketId,existingTicket);
        
        }

        // Delete Ticket
        public async Task<int> DeleteTicketAsync(string user, string ticketId)
        {
            var existingTicket = await _ticketRepository.GetByIdAsync(ticketId);
            if (existingTicket == null)
            {
                throw new Exception($"Ticket with ID ( {ticketId} ) NOT FOUND");
            }

            return await _ticketRepository.DeleteAsync(user, ticketId);
        }

        // Method to Generate QRCode from Ticket
        private byte[] GenerateQRCodeImage(TicketDTO ticketDto)
        {
            var writer = new BarcodeWriterPixelData
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 300
                }
            };

            var pixelData = writer.Write(ticketDto.ToString());
            using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb))
            {
                using (var ms = new MemoryStream())
                {
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
                    try
                    {
                        Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                    }
                    finally
                    {
                        bitmap.UnlockBits(bitmapData);
                    }

                    bitmap.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }

        public async Task<bool> CheckinTicketAsync(byte[] qrCode)
        {
            var ticket = await _ticketRepository.GetByQrCodeAsync(qrCode);
            if (ticket == null)
            {
                throw new Exception("Ticket not found.");
            }

            var seat = await _seatRepository.GetByIdAsync(ticket.SeatID);
            if (seat == null || !seat.IsAvailable)
            {
                throw new Exception("Seat is not available or not found.");
            }

            seat.IsAvailable = false;
            await _seatRepository.UpdateAsync("system", seat.SeatID, seat);

            return true;
        }
    }
}
