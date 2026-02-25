namespace Course.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        // Usar o base para acionar o construtor da superclasse (classe base) na subclasse(classe atual)
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) 
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
