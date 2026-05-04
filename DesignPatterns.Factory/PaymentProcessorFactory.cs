using DesignPatterns.Factory.Concrete;
using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory
{

    internal class PaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcessor(PaymentDetails paymentDetails)
        {
            var processors = new List<IPaymentProcessor>
            {
                new CreditCardProcessor(),
                new PaypalProcessor(),
                new BankTransferProcessor(),
                new CryptoProcessor()
            };

            return processors.FirstOrDefault(x => x.IsApplyingTo == paymentDetails.PaymentType);

            //switch (paymentDetails)
            //{
            //    case { PaymentType: PaymentTypes.CreditCard }:
            //        return new CreditCardProcessor();
            //    case { PaymentType: PaymentTypes.Paypal }:
            //        return new PaypalProcessor();
            //    case { PaymentType: PaymentTypes.BankTransfer }:
            //        return new BankTransferProcessor();
            //    case { PaymentType: PaymentTypes.Crypto }:
            //        return new CryptoProcessor();
            //    default:
            //        throw new NotSupportedException($"Payment type {paymentDetails.PaymentType} is not supported.");
            //}
        }
    }
}
