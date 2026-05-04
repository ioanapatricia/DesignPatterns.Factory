
using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory
{
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreatePaymentProcessor(PaymentDetails paymentDetails);
    }
}
