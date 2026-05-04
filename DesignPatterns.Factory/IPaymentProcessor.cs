using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory
{
    public interface IPaymentProcessor
    {
        PaymentTypes IsApplyingTo { get; }

        bool ValidatePayment(PaymentDetails paymentDetails);
        bool ProcessPayment(PaymentDetails paymentDetails);
    }
}
