using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class AtvProduto
    {
        public static void Exercicio()
        {
            Produto produto;

            produto = new Produto();

            Console.WriteLine("---------- Dados de um Produto ------------");
            Console.Write("Digite o Nome do Produto: ");
            produto.Nome = Console.ReadLine()!;
            Console.Write("Digite o Preço do Produto: R$");
            produto.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Digite a Quantidade de Produtos no Estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine()!);

            double valor = produto.ValorTotal();
            // não precisa do ToString() pois o C# já transforma o produto em String
            Console.WriteLine("Dados do Produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine()!);
            produto.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados do Atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser Reduzidos no estoque: ");
            qte = int.Parse(Console.ReadLine()!);
            if (produto.Quantidade - qte >= 0)
            {
                Console.WriteLine();
                produto.RemoverProdutos(qte);
                Console.WriteLine("Dados do Atualizados: " + produto);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Não é possivel remover mais do que o estoque possui...");
            }
        }
    }
}
