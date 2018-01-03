using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeSample.Models;
namespace CodeSample.Repository
{
    public class OrderRepository : IOrderRepository
    {
        //implementing Singleton design pattern 
        private static OrderRepository instance = null;
        private OrderRepository()
        {
        }
        public static OrderRepository GetInstance()
        {
            if (instance == null)
                instance = new OrderRepository();
            return instance;
        }
        //implementing Singleton design pattern 

        public List<Order> GetOrderList()
        {
            //dummy data added-- instead of this there should be a call to database or API/service which would fetch the actual data
            List<Order> liOrder = new List<Order>();
            //CreditCheck type object added to Order list
            liOrder.Add(CreditCheck.GetInstance(100, "Test Customer#1", 12345, new List<string>() { "service1", "service2" }));
            //CriminalReport type object added to Order list
            liOrder.Add(CriminalReport.GetInstance(101, "Test Customer#2", 12345, new List<string>() { "service1", "service2", "service3" }));
            //Paramed type object added to Order list
            liOrder.Add(Paramed.GetInstance(103, "Test Customer#3", 12345, new List<string>() { "service1" }));
            return liOrder;
        }
    }
}