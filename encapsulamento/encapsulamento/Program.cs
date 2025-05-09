using System;

class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
                preco = value;
            else
                Console.WriteLine("O preço não pode ser negativo.");
        }
    }
}

class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void Aniversario()
    {
        idade++;
        Console.WriteLine($"{nome} fez aniversário e agora tem {idade} anos.");
    }
}

class Endereco
{
    private string rua;
    private int numero;
    private string cidade;

    public Endereco(string rua, int numero, string cidade)
    {
        this.rua = rua;
        this.numero = numero;
        this.cidade = cidade;
    }

    public void ExibirEndereco()
    {
        Console.WriteLine($"Endereço: Rua {rua}, nº {numero} - {cidade}");
    }
}

class Funcionario
{
    private string nome;
    private decimal salario;

    public Funcionario(string nome, decimal salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public void AumentarSalario(decimal percentual)
    {
        if (percentual > 0)
        {
            salario += salario * percentual / 100;
            Console.WriteLine($"{nome} teve um aumento. Novo salário: R$ {salario:F2}");
        }
        else
        {
            Console.WriteLine("Percentual inválido para aumento salarial.");
        }
    }
}

// Programa principal para teste
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Produto ===");
        Produto p = new Produto("Camiseta", 50m);
        p.Preco = -10; // Testando validação
        Console.WriteLine($"Produto: {p.Nome} - Preço: R$ {p.Preco}");

        Console.WriteLine("\n=== Pessoa ===");
        Pessoa pessoa = new Pessoa("Ana", 29);
        pessoa.Aniversario();

        Console.WriteLine("\n=== Endereço ===");
        Endereco endereco = new Endereco("Av. Brasil", 1000, "São Paulo");
        endereco.ExibirEndereco();

        Console.WriteLine("\n=== Funcionário ===");
        Funcionario func = new Funcionario("Carlos", 3000m);
        func.AumentarSalario(10);
    }
}
