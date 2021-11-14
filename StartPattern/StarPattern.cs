using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.StartPattern
{
    class StarPattern
    {
        public void designStar(int num)
        {
            for(int i=0;i<=num;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        public void starPatternUpwords(int num)
        {
            for(int i=num;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public void pyramidPattern(int num)
        {
            for(int i=1;i<=num;i++)
            {
                for(int space=1;space<=num-i;space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
