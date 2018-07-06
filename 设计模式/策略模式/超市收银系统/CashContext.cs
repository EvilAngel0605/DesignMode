using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class CashContext
    {
        CashSuper cashSuper = null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "满300返100":
                    cashSuper = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cashSuper = new CashRebate("0.8");
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cashSuper.AcceptCash(money);
        }
    }
}
