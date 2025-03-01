using System;

namespace Loja
{
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

        public static Produto[] Carrinho = new Produto[10];
        public static int carrinhoIndex = 0;

        public static void MaterialEscolar()
        {
            Produto Caneta = new Produto("Caneta", 2.99);
            Produto Lapis = new Produto("Lápis", 1.99);
            Produto Caderno = new Produto("Caderno", 29.99);
            Produto Estojo = new Produto("Estojo", 5.99);

            Console.WriteLine($"Escolha o produto :\n1-Caneta R${Caneta.Value}\n2-Lápis R${Lapis.Value}\n3-Caderno R${Caderno.Value}\n4-Estojo R${Estojo.Value}\n5-Voltar");
            int EscMaterial = Convert.ToInt32(Console.ReadLine());

            switch (EscMaterial)
            {
                case 1:
                    Carrinho[carrinhoIndex] = Caneta;
                    carrinhoIndex++;
                    Console.WriteLine($"Caneta adicionada ao carrinho!");
                    break;

                case 2:
                    Carrinho[carrinhoIndex] = Lapis;
                    carrinhoIndex++;
                    Console.WriteLine($"Lápis adicionado ao carrinho!");
                    break;

                case 3:
                    Carrinho[carrinhoIndex] = Caderno;
                    carrinhoIndex++;
                    Console.WriteLine($"Caderno adicionado ao carrinho!");
                    break;

                case 4:
                    Carrinho[carrinhoIndex] = Estojo;
                    carrinhoIndex++;
                    Console.WriteLine($"Estojo adicionado ao carrinho!");
                    break;

                case 5:
                    Console.Clear();
                    Menu();
                    return;

                default:
                    Console.WriteLine("Resposta invalida, aperte qualquer tecla e reinicie o programa.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    return;

            }

            ExibirCarrinho();

            ContinuarCompra();
        }

        public static void Eletrodomesticos()
        {
            Produto Geladeira = new Produto("Geladeira", 2544.01);
            Produto MaquinaDeLavar = new Produto("Máquina de Lavar", 2706.55);
            Produto MicroOndas = new Produto("Micro-Ondas", 529.99);
            Produto Liquidificador = new Produto("Liquidificador", 99.90);

            Console.WriteLine($"Escolha o produto :\n1-Geladeira R${Geladeira.Value}\n2-Máquina de Lavar R${MaquinaDeLavar.Value}\n3-Micro-Ondas R${MicroOndas.Value}\n4-Liquidificador R${Liquidificador.Value}\n5-Voltar");
            int EscMaterial = Convert.ToInt32(Console.ReadLine());

            switch (EscMaterial)
            {
                case 1:
                    Carrinho[carrinhoIndex] = Geladeira;
                    carrinhoIndex++;
                    Console.WriteLine($"Geladeira adicionada ao carrinho!");
                    break;

                case 2:
                    Carrinho[carrinhoIndex] = MaquinaDeLavar;
                    carrinhoIndex++;
                    Console.WriteLine($"Máquina de Lavar adicionada ao carrinho!");
                    break;

                case 3:
                    Carrinho[carrinhoIndex] = MicroOndas;
                    carrinhoIndex++;
                    Console.WriteLine($"Micro-Ondas adicionado ao carrinho!");
                    break;

                case 4:
                    Carrinho[carrinhoIndex] = Liquidificador;
                    carrinhoIndex++;
                    Console.WriteLine($"Liquidificador adicionado ao carrinho!");
                    break;

                case 5:
                    Console.Clear();
                    Menu();
                    return;

                default:
                    Console.WriteLine("Resposta invalida, aperte qualquer tecla e reinicie o programa.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    return;

            }

            ExibirCarrinho();

            ContinuarCompra();
        }

        public static void IA()
        {
            Produto ChatGPT = new Produto("Chat-GPT", 20.99);
            Produto Photoshop = new Produto("PhotoshopIA", 39.99);
            Produto Excel = new Produto("Excel", 29.99);
            Produto GitHubCopilot = new Produto("GitHub Copilot", 0.99);

            Console.WriteLine($"Escolha o produto :\n1-Chat-GPT R${ChatGPT.Value}\n2-Photoshop R${Photoshop.Value}\n3-Excel R${Excel.Value}\n4-GitHub Copilot R${GitHubCopilot.Value}\n5-Voltar");
            int EscMaterial = Convert.ToInt32(Console.ReadLine());

            switch (EscMaterial)
            {
                case 1:
                    Carrinho[carrinhoIndex] = ChatGPT;
                    carrinhoIndex++;
                    Console.WriteLine($"Chat-GPT adicionado ao carrinho!");
                    break;

                case 2:
                    Carrinho[carrinhoIndex] = Photoshop;
                    carrinhoIndex++;
                    Console.WriteLine($"Photoshop adicionado ao carrinho!");
                    break;

                case 3:
                    Carrinho[carrinhoIndex] = Excel;
                    carrinhoIndex++;
                    Console.WriteLine($"Excel adicionado ao carrinho!");
                    break;

                case 4:
                    Carrinho[carrinhoIndex] = GitHubCopilot;
                    carrinhoIndex++;
                    Console.WriteLine($"GitHub Copilot adicionado ao carrinho!");
                    break;

                case 5:
                    Console.Clear();
                    Menu();
                    return;

                default:
                    Console.WriteLine("Resposta invalida, aperte qualquer tecla e reinicie o programa.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    return;
            }

            ExibirCarrinho();

            ContinuarCompra();
        }

        public static void ProdutosLimpeza()
        {
            Produto Amaciante = new Produto("Amaciante", 6.99);
            Produto SabaoPo = new Produto("Sabão em Pó", 3.99);
            Produto Detergente = new Produto("Detergente", 2.99);
            Produto Sabao = new Produto("Sabão", 1.99);

            Console.WriteLine($"Escolha o produto :\n1-Amaciante R${Amaciante.Value}\n2-Sabão em Pó R${SabaoPo.Value}\n3-Detergente R${Detergente.Value}\n4-Sabão R${Sabao.Value}\n5-Voltar");
            int EscMaterial = Convert.ToInt32(Console.ReadLine());

            switch (EscMaterial)
            {
                case 1:
                    Carrinho[carrinhoIndex] = Amaciante;
                    carrinhoIndex++;
                    Console.WriteLine($"Amaciante adicionado ao carrinho!");
                    break;

                case 2:
                    Carrinho[carrinhoIndex] = SabaoPo;
                    carrinhoIndex++;
                    Console.WriteLine($"Sabão em Pó adicionado ao carrinho!");
                    break;

                case 3:
                    Carrinho[carrinhoIndex] = Detergente;
                    carrinhoIndex++;
                    Console.WriteLine($"Detergente adicionado ao carrinho!");
                    break;

                case 4:
                    Carrinho[carrinhoIndex] = Sabao;
                    carrinhoIndex++;
                    Console.WriteLine($"Sabão adicionado ao carrinho!");
                    break;

                case 5:
                    Console.Clear();
                    Menu();
                    return;

                default:
                    Console.WriteLine("Resposta invalida, aperte qualquer tecla e reinicie o programa.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    return;

            }

            ExibirCarrinho();

            ContinuarCompra();
        }

        public static void ExibirCarrinho()
        {
            Console.WriteLine("\n📦 Seu Carrinho:");
            double total = 0;

            for (int i = 0; i < carrinhoIndex; i++)
            {
                if (Carrinho[i] != null)
                {
                    Console.WriteLine($"- {Carrinho[i].Name}: R${Carrinho[i].Value:F2}");
                    total += Carrinho[i].Value;
                }
            }

            Console.WriteLine($"💰 Total: R${total:F2}\n");
        }

        public static void ContinuarCompra()
        {
            Console.WriteLine("Deseja continuar a compra ? S/N");
            string resposta = Console.ReadLine();

            resposta = resposta.ToUpper();

            if (resposta == "S")
            {
                Console.Clear();
                Menu();
            }
            else if (resposta == "N")
            {
                Sair();
            }
            else
            {
                Console.WriteLine("Resposta invalida, Reinicie o programa.");
            }


        }

        public static void Sair()
        {
            Environment.Exit(0);
        }

        public static void Menu()
        {
            Console.WriteLine("Vendetudo.com\nEscolha seu produto\n1-Material Escolar\n2-Eletrodomésticos\n3-IA\n4-Material de Limpeza\n5-Sair");
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

        static void Main(string[] args)
        {
            Menu();
        }
    }
}