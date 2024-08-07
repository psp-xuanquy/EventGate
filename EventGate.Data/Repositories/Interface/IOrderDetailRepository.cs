﻿using EventGate.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories.Interface
{
    public interface IOrderDetailRepository
    {
        Task<List<OrderDetail>> GetByOrderIdAsync(string orderId);
        Task<OrderDetail> GetByIdAsync(string orderDetailId);
        Task AddAsync(string user, OrderDetail orderDetail);
        Task DeleteByOrderIdAsync(string user, string orderId);
    }
}
