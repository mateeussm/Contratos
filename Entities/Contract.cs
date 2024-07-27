using Contratos.Entities;

namespace Contratos.Entities
{
    class Contract
    {
        public int number { get; private set; }
        public DateTime date { get; private set; }
        public double totalValue { get; private set; }
        public List<Installment> installments { get; private set; } = new List<Installment>();
       

        public Contract()
        {
        }
        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
        }
        public void addInstallment(DateTime dueDate, double amount)
        {
            installments.Add(new Installment(dueDate,amount));
        }
    }
}
