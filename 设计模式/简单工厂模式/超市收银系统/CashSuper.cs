﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式.超市收银系统
{
    abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
