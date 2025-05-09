
using System;
using System.Collections.Generic;

class Forma
{
    public virtual double CalcularArea()
    {
        return 0;
    }
}

class Retangulo : Forma
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}

class Circulo : Forma
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}
class Funcionario
{
    public string Nome { get; set; }

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public virtual double CalcularSalario()
    {
        return 0;
    }
}

class Gerente : Funcionario
{
    public Gerente(string nome) : base(nome) {}

    public override double CalcularSalario()
    {
        return 10000.00; // exemplo
    }
}

class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome) : base(nome) {}

    public override double CalcularSalario()
    {
        return 7000.00; //salario da galera
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        List<Forma> formas = new List<Forma>
        {
            new Retangulo(5, 3),
            new Circulo(4)
        };

        Console.WriteLine("Áreas das formas:");
        foreach (var forma in formas)
        {
            Console.WriteLine(forma.CalcularArea());
        }

        Console.WriteLine();

        
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente("Ana"),
            new Desenvolvedor("Carlos")
        };

        Console.WriteLine("Salários dos funcionários:");
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"{funcionario.Nome}: R$ {funcionario.CalcularSalario()}");
        }
    }
}
