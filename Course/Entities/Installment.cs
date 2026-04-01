using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Installment
    {
        public DateOnly DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateOnly dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
