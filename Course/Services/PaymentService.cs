using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal class PaymentService
    {
        private IPaymentService _paymentService;

        public PaymentService(IPaymentService paymentService) {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
