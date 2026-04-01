using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal interface IPaymentService
    {
        double Payment(double amount);
    }
}
