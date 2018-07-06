using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Person
    {
        public Person()
        {

        }
        private string mName;
        public Person(string name)
        {
            mName = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", mName);
        }
    }
}
