using System.Globalization;

namespace Course.Entities
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public double ValorTotal()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            //if (Quantidade - quantidade >= 0)
            //{
            Quantidade -= quantidade;
            //} else {
            //    Console.WriteLine("Não foi possivel remover...");
            //}
        }
        // Serve para implicitamente ser chamado em um WriteLine com o que for escolhido
        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
