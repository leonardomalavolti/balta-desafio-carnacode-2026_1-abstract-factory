namespace DesignPatternChallenge.Domain.Interfaces;

public interface IPaymentGatewayFactory
{
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}