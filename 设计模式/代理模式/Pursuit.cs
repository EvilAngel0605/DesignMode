using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit (SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm + ",送你洋娃娃");
        }

        public void GiveDolls()
        {
            throw new NotImplementedException();
        }

        public void GiveFlowers()
        {
            throw new NotImplementedException();
        }
    }
}
