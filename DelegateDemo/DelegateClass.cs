using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.DelegateDemo
{
    public delegate void MyDelegate(string msg);
    public delegate void MySecondDelegate(int newInt);
   public class DelegateClass
    {
         public static void methodOne(string abc)
        {
            Console.WriteLine(abc);
        }

        public static void newDelegateMethod(int x)
        {
            Console.WriteLine("msg from newDelegateMethod"+x);
        }
    }

    public class ClassB
    {
         public static void methodTwo(string xyz)
        {
            Console.WriteLine("class B delegate");
        }
    }

    
}
