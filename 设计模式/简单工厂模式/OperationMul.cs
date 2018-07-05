using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class OperationMul:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = numberA * numberB;
            return result;
        }
    }
}
