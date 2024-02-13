using BankomatBlazorWebAssembly.Models;

namespace BankomatBlazorWebAssembly.Services
{
    public class BankomatService
    {

        public static int[] Nominals = { 200, 100, 50, 20 };


        public static int CalculateSum(List<Nominal> nominals)
        {
            int sum=0;
            foreach (Nominal nominal in nominals)
            {
                sum += nominal.NominalValue * nominal.NominalAmount;
            }

            return sum;
        }

        public int CalculateSumOfOperation(List<List<Nominal>>? operations)
        {
            var totalSum = 0;

            foreach (List<Nominal> operation in operations)
            {
                foreach (Nominal nominal in operation)
                {
                    totalSum += nominal.NominalValue * nominal.NominalAmount;
                }
            }


            return totalSum;
        }

        public int CalculateAmountOfNominals(List<List<Nominal>>? operations, int nominal)
        {
            var sumOfNominals = 0;

            foreach (List<Nominal> operation in operations)
            {
                sumOfNominals += operation.FirstOrDefault(operation => operation.NominalValue == nominal).NominalAmount;
            }

            return sumOfNominals;
        }
    }
}
