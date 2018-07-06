using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Decorator:Coffee 
    {
        private Coffee mCoffee;
        public Decorator(Coffee coffee)
        {
            mCoffee = coffee;
        }
        public override double Cost()
        {
            return mCoffee.Cost();
        }
    }
}
