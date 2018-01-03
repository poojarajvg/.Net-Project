using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSample.Models
{
    public sealed class Paramed : Order
    {
        //implementing Singleton design pattern 
        private static Paramed instance = null;
        private Paramed(Int64 orderId, string customerName, Int64 accountNumner, List<string> services) {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.AccountNumber = accountNumner;
            this.ServiceCollection = services;
        }
        public static Paramed GetInstance(Int64 orderId, string customerName, Int64 accountNumner, List<string> services)
        {
            if (instance == null)
                instance = new Paramed(orderId, customerName, accountNumner, services);
            else
            {
                instance.OrderId = orderId;
                instance.CustomerName = customerName;
                instance.AccountNumber = accountNumner;
                instance.ServiceCollection = services;
            }
            return instance;
        }
        //implementing Singleton design pattern 
        public override void AddService(string service)
        {
            //Paramed Add service called
        }

        public override void CancelOrder()
        {
            //Paramed Cancel order called
        }

        public override void SendToBilling()
        {
            //Paramed SendToBilling called
        }
    }
}