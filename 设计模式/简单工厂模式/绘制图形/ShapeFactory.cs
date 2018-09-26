
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式.绘制图形
{
    class ShapeFactory
    {
        /// <summary>
        /// 获取形状类型的对象
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null) return null;
            if (shapeType == "CIRCLE") return new Circle();
            else if (shapeType == "RECTANGLE") return new Rectangle();
            else if (shapeType == "SQUARE") return new Square();
            return null;
        }
    }
}
