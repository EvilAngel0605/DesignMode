using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashRebate : CashSuper
    {
        private double mMoneyRebate = 1;
        public  CashRebate(string moneyRebate)
        {
            mMoneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double money)
        {
            return money * mMoneyRebate;
        }
    }
}
