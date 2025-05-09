using System;

namespace HerancaVeiculos
{
    
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Veículo: {Marca} {Modelo}");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("O veículo está acelerando...");
        }
    }

    
    class Carro : Veiculo
    {
        public Carro(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
        }

        public override void Acelerar()
        {
            Console.WriteLine("O carro acelera  pela estrada.");
        }
    }

    
    class Moto : Veiculo
    {
        public Moto(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo}");
        }

        public override void Acelerar()
        {
            Console.WriteLine("A moto acelera no corredor.");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo meuCarro = new Carro("Toyota", "Corolla");
            Veiculo minhaMoto = new Moto("Yamaha", "MT-07");

            meuCarro.MostrarInfo();
            meuCarro.Acelerar();

            Console.WriteLine();

            minhaMoto.MostrarInfo();
            minhaMoto.Acelerar();
        }
    }
}
