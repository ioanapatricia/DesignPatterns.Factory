using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Concrete
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public PaymentTypes IsApplyingTo => PaymentTypes.CreditCard;

        public bool ValidatePayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment validated with Credit Card Transfer");
            return true;
        }

        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment processed with Credit Card Transfer\n");
            return true;
        }
    }
}
