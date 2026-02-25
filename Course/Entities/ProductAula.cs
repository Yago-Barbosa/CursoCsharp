using System.Globalization;
namespace Course.Entities
{
    // Ordem Sugerida para a implementação de membros de uma classe
    /*
     * Atributos Privados
     * Propriedades Autoimplementadas
     * Construtores
     * Propriedades Customizadas
     * Outros Métodos da Classe 
    */ 
    class ProductAula
    {
        // Classe do Produto utilizado em outra aula, mas agora com construtores
        // _nome nao pode receber auto properties pois possui uma logica particular
        private string _nome;
        // Já o Preco e Quantidade recebem uma auto properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        
        // Por convenção os nomes de atributos privados começam com _ e letra minuscula

        // Permite o Construtor padrão sem parametros
        public ProductAula(){}

        public ProductAula(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set {
                // Repor _nome por value com um valor que atualiza o _nome no set
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                } else
                {
                    Console.WriteLine("Erro ao mudar o Nome");
                }
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}