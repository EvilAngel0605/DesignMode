using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Decaf : Coffee
    {
        public override double Cost()
        {
            Console.WriteLine("脱咖啡因咖啡");
            return 2;
        }
    }
}
