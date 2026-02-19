using DesignPatternChallenge.Domain.Interfaces;

namespace DesignPatternChallenge.Gateways.PagSeguro;

public class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessTransaction(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}