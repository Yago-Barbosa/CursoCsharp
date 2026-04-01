using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal class PayPalPaymentService : IPaymentService
    {
        public double Payment(double amount)
        {
            return amount *= 0.01;
        }
    }
}
