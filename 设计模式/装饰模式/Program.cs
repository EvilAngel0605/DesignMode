using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("ZCC");
            //Sneakers sneakers = new Sneakers();
            //BigTrouser bigTrouser = new BigTrouser();
            //TShirts shirts = new TShirts();
            //sneakers.Decorate(person);
            //bigTrouser.Decorate(sneakers);
            //shirts.Decorate(bigTrouser);
            //shirts.Show
            Coffee coffee = new Mocha(new Decaf());
            Console.WriteLine("$:"+coffee.Cost());
        }
    }
}
