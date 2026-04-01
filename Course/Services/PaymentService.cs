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

        public void ProcessInstallment(Contract contract)
        { 
            double basicPayment = 0.0;
            DateOnly dueDate = contract.Date;


            double payment = _paymentService.Payment(basicPayment);
            contract.installments = new Installment(dueDate, payment);
        }
    }
}
