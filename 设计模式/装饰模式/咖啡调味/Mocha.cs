using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Mocha:Decorator
    {
        public Mocha(Coffee coffee):base(coffee)
        {

        }
        public override double Cost()
        {
            Console.Write("抹茶味的");
            return base.Cost()+0.5f;
        }
    }
}
