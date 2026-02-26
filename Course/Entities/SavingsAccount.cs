namespace Course.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { } 

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate; 
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // sobrescreve o método de saque, retirando a taxa de 5 reais
        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        // Utiliza a base do método de saque da conta comum e retira mais 2 reais (deixando a taxa em 7 reais para poupança)
        public override void Withdraw(double amount)
        {
            // Utilizar o prefixo base para indicar a execução do método base (saque)
            // Também já utilizamos o base em contrutores...
            base.Withdraw(amount);
            // E depois descontar mais 2 reais...
            Balance -= 2.0;
        }
    }
}
