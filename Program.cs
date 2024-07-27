using System;
using System.Globalization;
using Contratos.Entities;
using Contratos.Services;

namespace Contratos
{
    class Contratos
    {
        static void Main(string[] args)
        {
            try
            {
                Contract contracts;
                Console.WriteLine("Enter contract data");
                Console.Write("Contract Number: ");
                int contractNumber;
                while (!int.TryParse(Console.ReadLine(), out contractNumber))
                {
                    Console.WriteLine("Digite apenas números!");
                }
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double contractValue = Double.Parse(Console.ReadLine());
                Console.Write("Enter number of installments: ");
                int numberInstallments = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Installments:");

                contracts = new Contract(contractNumber, contractDate, contractValue);

                ContractService contractService = new ContractService();
                contractService.processContract(contracts, numberInstallments, new PaypalService());

                foreach (Installment i in contracts.installments)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}