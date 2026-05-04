using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Concrete
{
    public class PaypalProcessor : IPaymentProcessor
    {
        public PaymentTypes IsApplyingTo => PaymentTypes.Paypal;

        public bool ValidatePayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment validated with Paypal Transfer");
            return true;
        }

        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment processed with Paypal Transfer\n");
            return true;
        }
    }
}
