namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string? Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Adicionada uma regra ao saque de conta comum(taxa de 5 reais)
        // Conta poupança(sem taxa)
        // O prefixo virtual indica que o método pode ser sobrescrito ou sobreposto
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
