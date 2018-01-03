using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CodeSample.Models
{
    public abstract class Order
    {
        [DisplayName("Order Id")]
        public Int64 OrderId { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Account Number")]
        public Int64 AccountNumber { get; set; }
        [DisplayName("Service Collection")]
        public List<string> ServiceCollection { get; set; }
        public abstract void AddService(string service);
        public abstract void CancelOrder();
        public abstract void SendToBilling();
    }
    
}