namespace DesignPatternChallenge.Domain.Interfaces;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}