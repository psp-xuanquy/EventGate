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

        public async Task<int> AddAsync(Voucher voucher)
        {
            var existingVoucher = await _context.Vouchers.FirstOrDefaultAsync(v => v.VoucherID == voucher.VoucherID);
            if (existingVoucher != null)
            {
                throw new Exception("Voucher already exists");
            }

            await _context.Vouchers.AddAsync(voucher);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(Voucher voucher)
        {
            var existingVoucher = await _context.Vouchers.FirstOrDefaultAsync(v => v.VoucherID == voucher.VoucherID);
            if (existingVoucher == null)
            {
                throw new Exception("Voucher does not exist");
            }

            _context.Vouchers.Update(voucher);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(string voucherId)
        {
            var voucher = await _context.Vouchers.FirstOrDefaultAsync(v => v.VoucherID == voucherId);
            if (voucher == null)
            {
                throw new Exception("Voucher does not exist");
            }

            _context.Vouchers.Remove(voucher);
            return await _context.SaveChangesAsync();
        }

        public async Task<Voucher> GetByIdAsync(string voucherId)
        {
            var voucher = await _context.Vouchers.FirstOrDefaultAsync(v => v.VoucherID == voucherId);
            if (voucher == null)
            {
                throw new Exception("Voucher does not exist");
            }
            return voucher;
        }

        public async Task<IEnumerable<Voucher>> GetAllAsync()
        {
            return await _context.Vouchers.ToListAsync();
        }
    }
}
