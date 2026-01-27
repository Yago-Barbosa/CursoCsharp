using System;
using System.Globalization;
namespace Course
{
    class Construtores
    {
        public static void Encapsulamento()
        {
            Product p = new Product("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

            // Sem o encapsulamento o programador pode mudar livremente os valores
            //p.Quantidade = -10;
            // Ao deixar a Quantidade Privada, o exemplo de cima dará erro...
        }

        //Devido ao encapsulamento toda a aula anterior fica só comentada...
        public static void AulaConstrutor()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine()!);

            //Product p = new Product(nome, preco);

            // Possivel com a implementação do construtor Padrao
            Product p2 = new Product();

            // Sintaxe Alternativa para inicializar Valores,
            // mesmo sem construtores customizados,
            // ainda é necessario o Padrão

            //Product p3 = new Product { 
            //    _nome = "Tv",
            //    Preco = 500.00,
            //    Quantidade = 20
            //};

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine()!);
            //p.AdicionarProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine()!);
            //p.RemoverProdutos(qte);
            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
        }
    }
}