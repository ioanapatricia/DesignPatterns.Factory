using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Concrete
{
    public class CryptoProcessor : IPaymentProcessor
    {
        public PaymentTypes IsApplyingTo => PaymentTypes.Crypto;

        public bool ValidatePayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment validated with Crypto Transfer");
            return true;
        }

        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment processed with Crypto Transfer\n");
            return true;
        }
    }
}
