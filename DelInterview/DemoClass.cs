using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.DelInterview
{
    class DemoClass1
    {
        public virtual void getMeSomething()
        {
            Console.WriteLine("Inside A");
        }

        class B : DemoClass1
        {
            public override void getMeSomething()
            {
                Console.WriteLine("Inside B");
            }

        }

        class C : DemoClass1
        {
            public new void getMeSomething()
            {
                Console.WriteLine("Inside C");
            }

        }


    }
}
