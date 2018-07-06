using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if(numberB==0)
            {
                throw new Exception("除数不能为0!");
            }
            result = numberA / numberB;
            return result;
        }
    }
}
