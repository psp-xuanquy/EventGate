using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly AppDbContext _context;

        public VoucherRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all Voucher
        public async Task<List<Voucher>> GetAllAsync()
        {
            return await _context.Vouchers
                .Where(v => v.DeletedTime == null)
                .ToListAsync();
        }

        // Get Voucher by ID
        public async Task<Voucher> GetByIdAsync(string voucherId)
        {
            return await _context.Vouchers
                .Where(v => v.DeletedTime == null)
                .FirstOrDefaultAsync(v => v.VoucherID == voucherId);
        }

        // Add Voucher
        public async Task<int> AddAsync(string user, Voucher addVoucher)
        { 
            addVoucher.CreatedBy = user;
            addVoucher.LastUpdatedBy = user;
            addVoucher.LastUpdatedTime = DateTime.Now;

            await _context.Vouchers.AddAsync(addVoucher);
            return await _context.SaveChangesAsync();
        }

        // Update Voucher
        public async Task<int> UpdateAsync(string user, string voucherId, Voucher updateVoucher)
        {
            var existingVoucher = await _context.Vouchers.FirstOrDefaultAsync(v => v.VoucherID == voucherId && v.DeletedTime == null);

            existingVoucher.Code = updateVoucher.Code;
            existingVoucher.Quantity = updateVoucher.Quantity;
            existingVoucher.Discount = updateVoucher.Discount;
            existingVoucher.ValidDate = updateVoucher.ValidDate;
            existingVoucher.ExpirationDate = updateVoucher.ExpirationDate;
            existingVoucher.IsActive = updateVoucher.IsActive;
            existingVoucher.UserID = updateVoucher.UserID;
            existingVoucher.EventID = updateVoucher.EventID;
            existingVoucher.LastUpdatedBy = user;
            existingVoucher.LastUpdatedTime = DateTime.Now;

            //_context.Vouchers.Update(updateVoucher);
            return await _context.SaveChangesAsync();
        }

        // Delete Voucher
        public async Task<int> DeleteAsync(string user, string voucherId)
        {
            var voucherToDelete = await _context.Vouchers.FirstOrDefaultAsync(v => v.VoucherID == voucherId && v.DeletedTime == null);

            voucherToDelete.DeletedBy = user;
            voucherToDelete.DeletedTime = DateTime.Now;

            return await _context.SaveChangesAsync();
        }
    }
}
