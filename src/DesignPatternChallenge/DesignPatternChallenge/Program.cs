using DesignPatternChallenge.Application;
using DesignPatternChallenge.Domain.Interfaces;
using DesignPatternChallenge.Gateways.MercadoPago;
using DesignPatternChallenge.Gateways.PagSeguro;
using DesignPatternChallenge.Gateways.Stripe;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

// Escolhendo PagSeguro
IPaymentGatewayFactory factory = new PagSeguroFactory();
var service = new PaymentService(factory);
service.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

// Escolhendo MercadoPago
factory = new MercadoPagoFactory();
service = new PaymentService(factory);
service.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

// Escolhendo Stripe
factory = new StripeFactory();
service = new PaymentService(factory);
service.ProcessPayment(300.00m, "4234567890123456");