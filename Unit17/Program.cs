using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    internal class Program
    {
        static void Main(string[] args)

        {
            SalaryAccount SalaryAcc1 = new SalaryAccount();
            SalaryAcc1.Balance = 370;
            SalaryAcc1.CalculateInterest();
            Console.WriteLine(SalaryAcc1.AsString());

            CommonAccount CommonAcc1 = new CommonAccount();
            CommonAcc1.Balance = 370;
            CommonAcc1.CalculateInterest();
            Console.WriteLine(CommonAcc1.AsString());
            CommonAcc1.Balance = 5370;
            CommonAcc1.CalculateInterest();
            Console.WriteLine(CommonAcc1.AsString());

            Console.ReadKey();
        }
    }
}
