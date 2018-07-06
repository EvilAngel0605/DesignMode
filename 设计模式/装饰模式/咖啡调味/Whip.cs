using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Whip:Decorator
    {
        public Whip(Coffee coffee):base(coffee)
        {
        }
        public override double Cost()
        {
            return base.Cost()+0.1f;
        }
    }
}
