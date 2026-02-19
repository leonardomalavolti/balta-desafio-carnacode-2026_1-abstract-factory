## 🥁 CarnaCode 2026 - Desafio 01 - Abstract Factory

Oi, eu sou o **Leonardo Malavolti Monteiro** 👋 e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Abstract Factory** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger).
O código atual está muito acoplado e dificulta a adição de novos gateways.

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio

## 🧩 Desafio

Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento:

- PagSeguro  
- MercadoPago  
- Stripe  

Cada gateway possui seus próprios componentes:

- Processador de pagamento  
- Validador de cartão  
- Logger  

O código original utilizava um `switch-case` centralizado e instanciava diretamente as classes concretas, gerando:

- Alto acoplamento  
- Violação do OCP (Open/Closed Principle)  
- Violação do DIP (Dependency Inversion Principle)  
- Baixa escalabilidade

---

## 🎯 Objetivo

Aplicar o padrão **Abstract Factory** para:

- Eliminar o switch-case
- Desacoplar o `PaymentService`
- Garantir compatibilidade entre os componentes de cada gateway
- Permitir a adição de novos gateways sem modificar código existente

---

## 🏗️ Solução Arquitetural

Foi criada uma fábrica abstrata:

IPaymentGatewayFactory

E interfaces para os componentes:

- IPaymentValidator
- IPaymentProcessor
- IPaymentLogger

Cada gateway implementa sua própria família de objetos e sua própria fábrica concreta:

- PagSeguroFactory
- MercadoPagoFactory
- StripeFactory

O `PaymentService` depende apenas da abstração:

public PaymentService(IPaymentGatewayFactory factory)

Isso garante:

- ✔ Extensibilidade
- ✔ Baixo acoplamento
- ✔ Alta coesão
- ✔ Respeito aos princípios SOLID

---

## 📂 Estrutura do Projeto

Domain  
 └── Interfaces  

Gateways  
 ├── PagSeguro  
 ├── MercadoPago  
 └── Stripe  

Application  
 └── PaymentService  

---

## 💡 Benefícios Obtidos

- Adição de novos gateways sem alterar código existente
- Garantia de consistência entre os componentes de cada gateway
- Melhor organização e separação de responsabilidades
- Código preparado para injeção de dependência

---

## 📚 Aprendizados

Durante este desafio, reforcei conceitos importantes como:

- Design Patterns na prática
- Arquitetura orientada a abstrações
- SOLID aplicado a cenários reais
- Estruturação profissional de projetos .NET

---

## 🔥 Próximos Passos

- Implementar injeção de dependência via Microsoft.Extensions.DependencyInjection
- Adicionar testes unitários
- Evoluir para cenários multi-tenant

---

📌 Este projeto faz parte da minha evolução contínua como desenvolvedor backend .NET.

