using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.UpCasting
{
    public class UpCastings
    {
        public int xpos;
        public int ypos;

        public UpCastings()
        {

        }

        public UpCastings(int num1, int num2)
        {
            xpos = num1;
            ypos = num2;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Draw shape with{0},{1}",xpos,ypos);
        }
    }

    public class Square : UpCastings
    {
        public Square(int a, int b): base(a,b)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Draw square {0},{1}",xpos,ypos);
        }
    }

    public class Circle: UpCastings
    {
        public Circle(int a, int b): base(a,b)
        {
            
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Circle {0},{1}", xpos, ypos);
        }

        public void fillColor()
        {
            Console.WriteLine("Fill Color {0},{1}", xpos, ypos);
        }
    }



    
}
