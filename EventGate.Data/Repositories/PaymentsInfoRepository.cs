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
    public class PaymentsInfoRepository : IPaymentsInfoRepository
    {
        private readonly AppDbContext _context;

        public PaymentsInfoRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get All PaymentsInfo
        public async Task<List<PaymentsInfo>> GetAllAsync()
        {
            return await _context.PaymentsInfos
                .Where(c => c.DeletedTime == null)
                .ToListAsync();
        }

        // Get PaymentsInfo By ID
        public async Task<PaymentsInfo> GetByIdAsync(string paymentsInfoId)
        {
            return await _context.PaymentsInfos
                .Where(c => c.DeletedTime == null)
                .FirstOrDefaultAsync(c => c.PaymentsInfoID == paymentsInfoId);
        }

        // Add PaymentsInfo 
        public async Task<int> AddAsync(string user, PaymentsInfo addPaymentsInfo)
        {
            addPaymentsInfo.CreatedBy = user;
            addPaymentsInfo.LastUpdatedBy = user;
            addPaymentsInfo.LastUpdatedTime = DateTime.Now;

            await _context.PaymentsInfos.AddAsync(addPaymentsInfo);
            return await _context.SaveChangesAsync();
        }

        // Update PaymentsInfo
        public async Task<int> UpdateAsync(string user, string paymentsInfoId, PaymentsInfo updatePaymentsInfo)
        {
            var existingPaymentsInfo = await _context.PaymentsInfos.FirstOrDefaultAsync(c => c.PaymentsInfoID == paymentsInfoId && c.DeletedTime == null);
            if (existingPaymentsInfo != null)
            {
                existingPaymentsInfo.AccountHolderName = updatePaymentsInfo.AccountHolderName;
                existingPaymentsInfo.AccountNumber = updatePaymentsInfo.AccountNumber;
                existingPaymentsInfo.BankName = updatePaymentsInfo.BankName;
                existingPaymentsInfo.BankBranch = updatePaymentsInfo.BankBranch;
                existingPaymentsInfo.TotalPayments = updatePaymentsInfo.TotalPayments;
                existingPaymentsInfo.ValidDate = updatePaymentsInfo.ValidDate;
                existingPaymentsInfo.EventID = updatePaymentsInfo.EventID;
                existingPaymentsInfo.LastUpdatedBy = user;
                existingPaymentsInfo.LastUpdatedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        // Delete PaymentsInfo
        public async Task<int> DeleteAsync(string user, string paymentsInfoId)
        {
            var paymentsInfoToDelete = await _context.PaymentsInfos.FirstOrDefaultAsync(c => c.PaymentsInfoID == paymentsInfoId && c.DeletedTime == null);
            if (paymentsInfoToDelete != null)
            {
                paymentsInfoToDelete.DeletedBy = user;
                paymentsInfoToDelete.DeletedTime = DateTime.Now;

                return await _context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
