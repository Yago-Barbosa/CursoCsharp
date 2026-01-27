using System.Globalization;
namespace Course
{
    class Product
    {
        // Classe do Produto utilizado em outra aula, mas agora com construtores
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Permite o Construtor padrão sem parametros
        public Product(){}

        // Um construtor permite que um valor seja atribuido no inicio da execução
        public Product(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
          }

        // Exemplo de Sobrecarga...
        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; // Essa linha é dispensavel pois o valor padrao já é 0
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        // Override é usado para atribuir uma nova função ao ToString
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}