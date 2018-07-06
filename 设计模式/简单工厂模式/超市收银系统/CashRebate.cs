using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式.超市收银系统
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
