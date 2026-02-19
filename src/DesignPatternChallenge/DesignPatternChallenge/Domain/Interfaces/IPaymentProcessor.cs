namespace DesignPatternChallenge.Domain.Interfaces;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}