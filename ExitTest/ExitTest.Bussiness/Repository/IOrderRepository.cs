﻿using ExitTest.Bussiness.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExitTest.Bussiness.Repository
{
    public interface IOrderRepository
    {
        Task<int> AddCartOrder(Ordertable _event);
        Task<List<Ordertable>> GetAllCartProducts();
        Task<Ordertable> EditCart(Ordertable _product);
    }
}