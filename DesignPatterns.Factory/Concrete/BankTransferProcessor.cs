using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory.Concrete
{
    public class BankTransferProcessor : IPaymentProcessor
    {
        public PaymentTypes IsApplyingTo => PaymentTypes.BankTransfer;

        public bool ValidatePayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment validated with Bank Transfer");
            return true;
        }

        public bool ProcessPayment(PaymentDetails paymentDetails)
        {
            Console.WriteLine("Payment processed with Bank Transfer\n");
            return true;
        }
    }
}
