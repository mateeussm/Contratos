using Contratos.Entities;
namespace Contratos.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public void processContract(Contract contract, int numberInstallments, IOnlinePaymentService onlinePaymentService)
        {
            for (int i = 1; i <= numberInstallments; i++)
            {
                Double valuePerMonth = 0.0;
                valuePerMonth = contract.totalValue / numberInstallments;
                DateTime nextMonth = contract.date.AddMonths(i);
                double amount = onlinePaymentService.PaymentFee(onlinePaymentService.Interest(valuePerMonth, i));
                contract.addInstallment(nextMonth,amount);
            }
        }
    }
}


