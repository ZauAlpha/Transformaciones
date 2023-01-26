using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Escalado
{
    public class Square
    {
        Pen pen= Pens.Gray;
        PointF a,b,c,d;
        
        
        public Square(int x1, int y1, int x2, int y2, Graphics graphics) {
            a= new PointF(x1, y1);
            b= new PointF(x2, y1);
            c= new PointF(x1, y2);
            d= new PointF(x2, y2);
        
        }
        public Square(float x1, float y1, float x2, float y2, Graphics graphics)
        {
            a = new PointF(x1, y1);
            b = new PointF(x2, y1);
            c = new PointF(x1, y2);
            d = new PointF(x2, y2);

        }
        public void rotate(float angle)
        {
            
        }
        

    }
}
