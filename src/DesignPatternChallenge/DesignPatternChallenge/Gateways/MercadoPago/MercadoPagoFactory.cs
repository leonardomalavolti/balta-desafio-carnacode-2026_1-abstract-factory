
using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Gateways.MercadoPago;

public class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreateLogger()
        => new MercadoPagoLogger();

    public IPaymentProcessor CreateProcessor()
        => new MercadoPagoProcessor();

    public IPaymentValidator CreateValidator()
        => new MercadoPagoValidator();
}