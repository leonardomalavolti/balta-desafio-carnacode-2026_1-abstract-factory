using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Application;

public class PaymentService
{
    private readonly IPaymentValidator _paymentValidator;
    private readonly IPaymentProcessor _paymentProcessor;
    private readonly IPaymentLogger _paymentLogger;

    public PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
    {
        _paymentValidator = paymentGatewayFactory.CreateValidator();
        _paymentProcessor = paymentGatewayFactory.CreateProcessor();
        _paymentLogger = paymentGatewayFactory.CreateLogger();
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_paymentValidator.ValidateCard(cardNumber))
        {
            Console.WriteLine("Cartão inválido");
            return;
        }
        var result = _paymentProcessor.ProcessTransaction(amount, cardNumber);
        _paymentLogger.Log($"Transação processada: {result}");
    }
}