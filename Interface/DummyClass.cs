using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.Interface
{
    public interface DemoInterface
    {
        void draw();
        void Bc();
        
        
    }
    public abstract class DummyClass
    {
        public abstract void AbstractDraw1();
        public abstract void Absx();
        void abstractDraw()
        {
            Console.WriteLine("from abstract class");
        }

       
    }

    public class TestClass : DummyClass,DemoInterface
    {
        public override void AbstractDraw1()
        {
            
            Console.WriteLine("from AbstractDraw1 method of DummyClass");
        }

        public override void Absx()
        {
            throw new NotImplementedException();
        }

        public  void Bc()
        {
            throw new NotImplementedException();
        }

        public void draw()
        {
            Console.WriteLine("from draw method of DemoInterface");
        }
    }
}
