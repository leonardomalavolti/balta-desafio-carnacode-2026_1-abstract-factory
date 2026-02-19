using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Gateways.Stripe;

public class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger()
        => new StripeLogger();

    public IPaymentProcessor CreateProcessor()
        => new StripeProcessor();

    public IPaymentValidator CreateValidator()
        => new StripeValidator();
}