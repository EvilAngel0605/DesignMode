﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashReturn : CashSuper
    {
        private double mMoneyCondition = 0d;
        private double mMoneyReturn = 0;
        public CashReturn(string  moneyCondition,string moneyReturn)
        {
            mMoneyCondition = double.Parse(moneyCondition);
            mMoneyReturn = double.Parse(moneyReturn);
        }
        public override double AcceptCash(double money)
        {
            double result;
            result = money -Math.Floor(money / mMoneyCondition) * mMoneyReturn;
            return result;
        }
    }
}
