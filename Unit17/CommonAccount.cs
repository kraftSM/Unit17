using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    public class CommonAccount : AbstractAccount

    {
        public CommonAccount()
        { Type = "Обычный"; }
        override public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = base.Interest;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
        
            

    }
}
