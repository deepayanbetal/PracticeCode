using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.SingletonEg
{
     public sealed class SingletonClass
    {
        private static SingletonClass _singletonInstance = null;
        private static int counter = 0;

        private SingletonClass()
        {
            counter++;
            Console.WriteLine("Counter value" + counter.ToString());
        }

        public static SingletonClass GetSingleton()
        {
            if(_singletonInstance== null)
            {
                _singletonInstance = new SingletonClass();
            }
            return _singletonInstance;
        }

        public void singletonmethod(string msg)
        {
            Console.WriteLine(msg);
        }





    }
}
