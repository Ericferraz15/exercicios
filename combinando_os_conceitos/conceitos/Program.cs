using System;
using System.Collections.Generic;

// 7. ContaBancaria e ContaPoupanca
class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; protected set; }

    public ContaBancaria(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public virtual void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso.");
        }
    }

    public virtual void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saque não permitido.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Conta {NumeroConta} - Saldo: R$ {Saldo:F2}");
    }
}

class ContaPoupanca : ContaBancaria
{
    public double TaxaJuros { get; set; }

    public ContaPoupanca(string numeroConta, double saldoInicial, double taxaJuros)
        : base(numeroConta, saldoInicial)
    {
        TaxaJuros = taxaJuros;
    }

    public override void Sacar(double valor)
    {
        double valorComJuros = valor + (valor * TaxaJuros);
        if (valorComJuros <= Saldo)
        {
            Saldo -= valorComJuros;
            Console.WriteLine($"Saque de R$ {valor} com juros de {TaxaJuros * 100}% realizado.");
        }
        else
        {
            Console.WriteLine("Saque não permitido: saldo insuficiente considerando a taxa de juros.");
        }
    }
}

// 8. Produto, ProdutoEletronico e ProdutoAlimenticio
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public virtual void MostrarDetalhes()
    {
        Console.WriteLine($"Produto: {Nome} - Preço: R$ {Preco:F2}");
    }
}

class ProdutoEletronico : Produto
{
    public ProdutoEletronico(string nome, double preco)
        : base(nome, preco) {}

    public override void MostrarDetalhes()
    {
        Console.WriteLine($"[Eletrônico] {Nome} - R$ {Preco:F2}");
    }
}

class ProdutoAlimenticio : Produto
{
    public ProdutoAlimenticio(string nome, double preco)
        : base(nome, preco) {}

    public override void MostrarDetalhes()
    {
        Console.WriteLine($"[Alimento] {Nome} - R$ {Preco:F2}");
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Teste com contas
        Console.WriteLine("=== Contas Bancárias ===");
        ContaBancaria conta1 = new ContaBancaria("123", 1000);
        ContaPoupanca conta2 = new ContaPoupanca("456", 1000, 0.02);

        conta1.Depositar(200);
        conta1.Sacar(300);
        conta1.MostrarSaldo();

        conta2.Depositar(100);
        conta2.Sacar(500);
        conta2.MostrarSaldo();

        Console.WriteLine("\n=== Lista de Produtos ===");
        List<Produto> produtos = new List<Produto>
        {
            new ProdutoEletronico("Notebook", 3500),
            new ProdutoAlimenticio("Arroz", 25)
        };

        foreach (var produto in produtos)
        {
            produto.MostrarDetalhes();
        }
    }
}
