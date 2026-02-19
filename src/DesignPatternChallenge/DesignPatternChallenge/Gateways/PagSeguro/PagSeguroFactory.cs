using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Gateways.PagSeguro;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger()
        => new PagSeguroLogger();

    public IPaymentProcessor CreateProcessor()
        => new PagSeguroProcessor();

    public IPaymentValidator CreateValidator()
        => new PagSeguroValidator();
}