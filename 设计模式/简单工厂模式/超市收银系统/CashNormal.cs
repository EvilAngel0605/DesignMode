using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式.超市收银系统
{
    class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
