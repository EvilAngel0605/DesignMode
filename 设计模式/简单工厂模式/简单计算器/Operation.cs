using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Operation
    {
        private double mNumberA;
        private double mNumberB;
        public double numberA
        {
            get { return mNumberA;}
            set { mNumberA = value; }
        }
        public double numberB
        {
            get { return mNumberB; }
            set { mNumberB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
