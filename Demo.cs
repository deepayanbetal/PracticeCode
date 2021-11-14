using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms
{
    class Demo
    {
        public void caller()
        {
            
            afterref(out int initialValue);
            Console.WriteLine(initialValue);

        }

        private int afterref(out int valueFromCaller)
        {
            int initialValue = 10;
            valueFromCaller = initialValue + 10;
            return valueFromCaller;
        }
    }
}
