using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Proxy : IGiveGift
    {
        private Pursuit mPursuit;
        public Proxy(Pursuit pursuit)
        {
            mPursuit = pursuit;
        }
        public void GiveChocolate()
        {
            mPursuit.GiveChocolate();
        }

        public void GiveDolls()
        {
            mPursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            mPursuit.GiveFlowers();
        }
    }
}
