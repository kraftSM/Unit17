using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    public class SalaryAccount    : AbstractAccount

    {
        public SalaryAccount()
        { Type = "Зарплатный"; }
        override public void CalculateInterest()
        {
            // расчет процентной ставки зарплатного  аккаунта по правилам банка
            Interest -= Balance * 0.5;
        }
    }
}
