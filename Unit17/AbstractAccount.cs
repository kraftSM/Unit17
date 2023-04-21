using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17
{
    public class AbstractAccount : IInterest
    {

        const double defInterestVal = 0.4;
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest
        { get; set; }
        public virtual void CalculateInterest()
        {
            Interest = defInterestVal * Balance;
        }
        public string AsString()
        {
            return string.Format("Type:{0} Balance:{1} Interest:{2}", Type, Balance.ToString(), Interest.ToString());
        }
    }
}
