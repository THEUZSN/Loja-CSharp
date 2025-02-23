using System;
using System.Linq;
using Loja;

namespace Loja;

public class Produto
{
    public static int idADD = 1;

    private int Id;
    public string Name { get; }
    public double Value { get; }

    public Produto(string name, double value)
    {
        Id = idADD++;
        Name = name;
        Value = value;
    }
    public static void MaterialEscolar()
    {
        Produto Caneta = new Produto("caneta", 2.99);
        Produto Lapis = new Produto("lapis", 1.99);
        Produto Caderno = new Produto("caderno", 29.99);
        Produto Estojo = new Produto("estojo", 5.99);

        Console.WriteLine($"Escolha o produto :\n1-Caneta R${Caneta.Value}\n2-Lapis R${Lapis.Value}\n3-Caderno R${Caderno.Value}\n4-Estojo R${Estojo.Value}\n5-Voltar");
        int EscMaterial = Convert.ToInt32(Console.ReadLine());

        switch (EscMaterial)
        {
            case 1:
                Console.WriteLine($"Compra da {Caneta.Name} de R${Caneta.Value} feita com sucesso");
                break;

            case 2:
                Console.WriteLine($"Compra da {Lapis.Name} de R${Lapis.Value} feita com sucesso");
                break;

            case 3:
                Console.WriteLine($"Compra da {Caderno.Name} de R${Caderno.Value} feita com sucesso");
                break;

            case 4:
                Console.WriteLine($"Compra da {Estojo.Name} de R${Estojo.Value} feita com sucesso");
                break;

            case 5:
                Console.Clear();
                Menu();
                break;
        }

    }

    public static void Eletrodomesticos()
    {
        Produto Geladeira = new Produto("geladeira", 2544.01);
        Produto MaquinaDeLavar = new Produto("maquinaDeLavar", 2706.55);
        Produto MicroOndas = new Produto("micro-ondas", 529.99);
        Produto Liquidificador = new Produto("liquidificador", 99.90);

        Console.WriteLine($"Escolha o produto :\n1-Geladeira R${Geladeira.Value}\n2-Maquina de Lavar R${MaquinaDeLavar.Value}\n3-Micro-Ondas R${MicroOndas.Value}\n4-Liquidificador R${Liquidificador.Value}\n5-Voltar");
        int EscMaterial = Convert.ToInt32(Console.ReadLine());

        switch (EscMaterial)
        {
            case 1:
                Console.WriteLine($"Compra da {Geladeira.Name} de R${Geladeira.Value} feita com sucesso");
                break;

            case 2:
                Console.WriteLine($"Compra da {MaquinaDeLavar.Name} de R${MaquinaDeLavar.Value} feita com sucesso");
                break;

            case 3:
                Console.WriteLine($"Compra da {MicroOndas.Name} de R${MicroOndas.Value} feita com sucesso");
                break;

            case 4:
                Console.WriteLine($"Compra da {Liquidificador.Name} de R${Liquidificador.Value} feita com sucesso");
                break;

            case 5:
                Console.Clear();
                Menu();
                break;
        }

    }

    public static void IA()
    {
        Produto ChatGPT = new Produto("Chat-GPT", 20.99);
        Produto Photoshop = new Produto("photoshopIA", 39.99);
        Produto Excel = new Produto("excel", 29.99);
        Produto GitHubCopilot = new Produto("GitHub Copilot", 0.99);

        Console.WriteLine($"Escolha o produto :\n1-Chat-GPT R${ChatGPT.Value}\n2-Photoshop R${Photoshop.Value}\n3-Exel R${Excel.Value}\n4-GitHib Copilot R${GitHubCopilot.Value}\n5-Voltar");
        int EscMaterial = Convert.ToInt32(Console.ReadLine());

        switch (EscMaterial)
        {
            case 1:
                Console.WriteLine($"Compra da {ChatGPT.Name} de R${ChatGPT.Value} feita com sucesso");
                break;

            case 2:
                Console.WriteLine($"Compra da {Photoshop.Name} de R${Photoshop.Value} feita com sucesso");
                break;

            case 3:
                Console.WriteLine($"Compra da {Excel.Name} de R${Excel.Value} feita com sucesso");
                break;

            case 4:
                Console.WriteLine($"Compra da {GitHubCopilot.Name} de R${GitHubCopilot.Value} feita com sucesso");
                break;

            case 5:
                Console.Clear();
                Menu();
                break;
        }

    }

    public static void ProdutosLimpeza()
    {
        Produto Amaciante = new Produto("amaciante", 6.99);
        Produto SabaoPo = new Produto("sabão em pó", 3.99);
        Produto Detergente = new Produto("detergente", 2.99);
        Produto Sabao = new Produto("sabão", 1.99);

        Console.WriteLine($"Escolha o produto :\n1-Amaciante R${Amaciante.Value}\n2-Sabão em Pó R${SabaoPo.Value}\n3-Detergente R${Detergente.Value}\n4-Sabão R${Sabao.Value}\n5-Voltar");
        int EscMaterial = Convert.ToInt32(Console.ReadLine());

        switch (EscMaterial)
        {
            case 1:
                Console.WriteLine($"Compra do {Amaciante.Name} de R${Amaciante.Value} feita com sucesso");
                break;

            case 2:
                Console.WriteLine($"Compra do {SabaoPo.Name} de R${SabaoPo.Value} feita com sucesso");
                break;

            case 3:
                Console.WriteLine($"Compra do {Detergente.Name} de R${Detergente.Value} feita com sucesso");
                break;

            case 4:
                Console.WriteLine($"Compra do {Sabao.Name} de R${Sabao.Value} feita com sucesso");
                break;

            case 5:
                Console.Clear();
                Menu();
                break;
        }

    }

    public static void Sair()
    {
        Environment.Exit(0);
    }

    public static void Menu()
    {
        Console.WriteLine("Vendetudo.com\nEscolha seu produto\n1-Material Escolar\n2-Eletrodomesticos\n3-IA\n4-Material de Limpeza\n5-Sair");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Clear();
                MaterialEscolar();
                break;

            case 2:
                Console.Clear();
                Eletrodomesticos();
                break;

            case 3:
                Console.Clear();
                IA();
                break;

            case 4:
                Console.Clear();
                ProdutosLimpeza();
                break;

            case 5:
                Sair();
                break;
        }
    }
}


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Seja bem vindo a ");
        Produto.Menu();
        Console.ReadLine();
    }
}