using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSample.Models
{
    public sealed class CreditCheck : Order
    {
        //implementing Singleton design pattern 
        private static CreditCheck instance = null;
        private CreditCheck(Int64 orderId, string customerName, Int64 accountNumner, List<string> services) {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.AccountNumber= accountNumner;
            this.ServiceCollection = services;
        }
        public static CreditCheck GetInstance(Int64 orderId, string customerName, Int64 accountNumner, List<string> services)
        {
            if (instance == null)
                instance = new CreditCheck(orderId, customerName, accountNumner, services);
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
            //CreditCheck Add service called
        }

        public override void CancelOrder()
        {
            //CreditCheck Cancel order called
        }

        public override void SendToBilling()
        {
            //CreditCheck SendToBilling called
        }
    }
}