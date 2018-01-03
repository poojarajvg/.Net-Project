using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeSample.Models;
namespace CodeSample.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrderList();
    }
}