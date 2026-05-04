using DesignPatterns.Factory;
using DesignPatterns.Factory.Models;

class Program
{
    static void Main()
    {
        IPaymentProcessorFactory paymentProcessorFactory = new PaymentProcessorFactory();

        // Example 1: Credit Card Payment
        var creditCardDetails = new PaymentDetails
        {
            PaymentType = PaymentTypes.CreditCard,
            OrderId = "ORD-001",
            Amount = 99.99m,
            Currency = "USD",
            CustomerEmail = "john@example.com",
        };

        var creditCardProcessor = paymentProcessorFactory.CreatePaymentProcessor(creditCardDetails);
        creditCardProcessor.ValidatePayment(creditCardDetails);
        creditCardProcessor.ProcessPayment(creditCardDetails);

        // Example 2: PayPal Payment
        var paypalDetails = new PaymentDetails
        {
            PaymentType = PaymentTypes.Paypal,
            OrderId = "ORD-002",
            Amount = 149.99m,
            Currency = "USD",
            CustomerEmail = "jane@example.com",
        };

        var paypalProcessor = paymentProcessorFactory.CreatePaymentProcessor(paypalDetails);
        paypalProcessor.ValidatePayment(paypalDetails);
        paypalProcessor.ProcessPayment(paypalDetails);

        // Example 3: Bank Transfer
        var bankDetails = new PaymentDetails
        {
            PaymentType = PaymentTypes.BankTransfer,
            OrderId = "ORD-003",
            Amount = 500.00m,
            Currency = "USD",
            CustomerEmail = "company@example.com",
        };

        var bankProcessor = paymentProcessorFactory.CreatePaymentProcessor(bankDetails);
        bankProcessor.ValidatePayment(bankDetails);
        bankProcessor.ProcessPayment(bankDetails);

        // Example 4: Crypto Payment
        var cryptoDetails = new PaymentDetails
        {
            PaymentType = PaymentTypes.Crypto,
            OrderId = "ORD-004",
            Amount = 0.05m,
            Currency = "Bitcoin",
            CustomerEmail = "crypto@example.com",
        };


        var cryptoProcessor = paymentProcessorFactory.CreatePaymentProcessor(cryptoDetails);
        cryptoProcessor.ValidatePayment(cryptoDetails);
        cryptoProcessor.ProcessPayment(bankDetails);
    }
}
