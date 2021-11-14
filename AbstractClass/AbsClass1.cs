using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.AbstractClass
{
    abstract class demoClass
    {
        public virtual void Set()
        {

        }

        public abstract void Set2();
        

        
    }

    class AbsClass1 : demoClass
    {
         public override void Set2()
        {
            throw new NotImplementedException();
        }
    }
}
