using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSample.Models
{
    public sealed class CriminalReport : Order
    {
        //implementing Singleton design pattern 
        private static CriminalReport instance = null;
        private CriminalReport(Int64 orderId, string customerName, Int64 accountNumner, List<string> services) {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.AccountNumber = accountNumner;
            this.ServiceCollection = services;
        }
        public static CriminalReport GetInstance(Int64 orderId, string customerName, Int64 accountNumner, List<string> services)
        {
            if (instance == null)
                instance = new CriminalReport(orderId, customerName, accountNumner, services);
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
            //CriminalReport Add service called
        }

        public override void CancelOrder()
        {
            //CriminalReport Cancel order called
        }

        public override void SendToBilling()
        {
            //CriminalReport SendToBilling called
        }
    }
}