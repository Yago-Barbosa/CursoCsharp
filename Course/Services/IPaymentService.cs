using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal interface IPaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
