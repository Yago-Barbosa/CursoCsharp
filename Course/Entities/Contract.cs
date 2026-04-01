using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateOnly Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> installments { get; set; }

        public Contract(int number, DateOnly date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

    }
}
