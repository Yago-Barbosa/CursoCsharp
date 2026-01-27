using System.Globalization;
namespace Course
{
    class Product
    {
        // Classe do Produto utilizado em outra aula, mas agora com construtores
        private string _nome;
        private double _preco;
        private int _quantidade;
        // Por convenção os nomes de atributos privados começam com _ e letra minuscula

        // Permite o Construtor padrão sem parametros
        public Product(){
        }

        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                // Repor _nome por value com um valor que atualiza o _nome no set
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        //public string GetNome() {
        //    return _nome; 
        //}

        // é possivel adicionar uma logica para impedir "Valores Inconsistentes"
        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome= nome;
        //    } 
        //}

        // Colocando somente o Get Preco e Quantidade eu posso impedir que esses valores sejam alterados,
        // porém eles podem ser "chamados"

        // O this permite que o construtor receba o valor de outros construtores, reduzindo o numero de linhas...
        // Tambem pode ser usado para passar o proprio objeto como argumento na chamada de um metodo ou construtor
        //public Product(string nome, double preco) : this() {
        //    Nome = nome;
        //    Preco = preco;
        //}

        //// Outro uso para o this...
        //public Product(string nome, double preco, int quantidade) : this(nome, preco){
        //    Quantidade = quantidade;
        //}


        // Um construtor permite que um valor seja atribuido no inicio da execução
        //public Product(string nome, double preco, int quantidade)
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}

        // Exemplo de Sobrecarga...
        //public Product(string nome, double preco)
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = 5; // Essa linha é dispensavel pois o valor padrao já é 0
        //}
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        // Override é usado para atribuir uma nova função ao ToString
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}