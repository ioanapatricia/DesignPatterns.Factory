using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory.Models
{
    public class PaymentDetails
    {
        public PaymentTypes PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string OrderId { get; set; }
        public string CustomerEmail { get; set; }   
    }
}
