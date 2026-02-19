using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Gateways.Stripe;

public class StripeValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("4");
    }
}