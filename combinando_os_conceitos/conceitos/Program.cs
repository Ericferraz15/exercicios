using System;

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
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
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
            Console.WriteLine("Saque não permitido: saldo insuficiente ou valor inválido.");
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
            Console.WriteLine($"Saque de R$ {valor} com taxa de juros de {TaxaJuros * 100}% realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saque não permitido: saldo insuficiente considerando a taxa de juros.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria("001", 1000);
        ContaPoupanca conta2 = new ContaPoupanca("002", 1000, 0.02); 

        conta1.Depositar(500);
        conta1.Sacar(200);
        conta1.MostrarSaldo();

        Console.WriteLine();

        conta2.Depositar(300);
        conta2.Sacar(500); 
        conta2.MostrarSaldo();
    }
}
