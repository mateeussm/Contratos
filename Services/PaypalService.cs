namespace Contratos.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount + (amount * 0.02);
        }
        public double Interest(double amount, int numberInstallments)
        { 
                return amount + (amount*(0.01 * numberInstallments));
        }
    }
}
