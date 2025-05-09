using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /* 
        1. Classes e Construtores
        1.Crie uma classe chamada Animal com um atributo Nome e um construtor que inicializa esse atributo. Adicione um método FazerSom() que exiba uma mensagem genérica.

        2.Crie uma classe chamada Gato que herde de Animal. O construtor de Gato deve chamar o construtor da classe base e inicializar o nome do gato.
        Sobrescreva o método FazerSom() para que exiba "Miau".
        */
        public class Animal
        {
            public string Nome { get; set; }
            public Animal(string nome)
            {
                Nome = nome;
            }
            public virtual void FazerSom()
            {
                Console.WriteLine("barulho do bixo.");
            } }
            public class Gato : Animal
            {
                public Gato(string nome) : base(nome)
                {
                   
                }
                public override void FazerSom()
                {
                    Console.WriteLine("Miau");
                }
            }
        
        static void Main(string[] args)
        {
            Animal animal = new Animal("bezerro");
            animal.FazerSom();

            Gato gato = new Gato("Mimi");
            gato.FazerSom();
        }
    }


}
