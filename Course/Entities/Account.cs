using Course.Entities.Exceptions;
using System.Linq.Expressions;

namespace Course.Entities
{
    // Conta se tornará uma classe abstrata para a aula 117
    internal class Account
    {
        public int Number { get; private set; }
        public string? Holder { get; private set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // Adicionada uma regra ao saque de conta comum(taxa de 5 reais)
        // Conta poupança(sem taxa)
        // O prefixo virtual indica que o método pode ser sobrescrito ou sobreposto
        public virtual void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds the withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
