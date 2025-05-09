using System;

public class Animal
{
 
    public string Nome { get; set; }

  
    public Animal(string nome)
    {
        Nome = nome;
    }

   
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

public class Gato : Animal
{
    // Construtor de Gato que chama o construtor da classe base
    public Gato(string nome) : base(nome)
    {
    }

    // Sobrescreve o método FazerSom para o Gato fazer "Miau"
    public override void FazerSom()
    {
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando Animal diretamente
        Animal animal = new Animal("bezerro");
        animal.FazerSom();  // Saída: O animal faz um som.

        // Instanciando Gato
        Gato gato = new Gato("Mimi");
        gato.FazerSom();  // Saída: Miau
    }
}
