using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式.绘制图形
{
    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle:Draw() method");
        }
    }
}
