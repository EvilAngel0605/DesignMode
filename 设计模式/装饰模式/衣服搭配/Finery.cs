using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Finery:Person
    {
        protected Person mPerson;
        //打扮
        public void Decorate(Person person)
        {
            mPerson = person;
        }
        public override void Show()
        {
            if(mPerson!=null)
            {
                mPerson.Show();
            }
        }
    }
}
