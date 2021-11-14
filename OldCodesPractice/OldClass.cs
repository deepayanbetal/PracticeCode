using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.OldCodesPractice
{
    class OldClass
    {
        public void starPattern(int star)
        {
            for(int i=0;i<= star;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void reversePattern(int star)
        {
            for(int i=star;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void charCount(string msg)
        {
            

            var frq = from x in msg
                      group x by x into y
                      select y;
            foreach(var ArrElm in frq)
            {
                Console.WriteLine(ArrElm.Key+":"+ArrElm.Count());
            }
            
        }
        
        public void eliminatetrapace(string msg)
        {
            Console.Write(msg.Replace("suck", "fuck"));
        }

        public void spaceCount(string msg)
        {
            
            var ele = from x in msg
                      group x by x into y
                      select y;
            foreach(var e in ele)

            {
                if(e.Key.ToString()== " ")
                {
                    Console.Write(e.Count());
                }
            }
            
        }

        public void Abbriviation(string msg)
        {
            
            char[] temp = new char[100];
            char[] charArray = msg.ToCharArray();
            temp[0]= charArray[0]  ;
            temp[1] = '.';
            var j = 2;
            var k =0;
            for(int i=1;i< charArray.Length;i++)
            {
                if(charArray[i]==' ')
                {
                    k = i;
                    i++;
                    temp[j] = charArray[i];
                    j++;
                    temp[j] = '.';
                    j++;
                }
                
            }
            //Console.Write(j);
            j = j - 2;
            while(charArray[k] != charArray[charArray.Length-1])
            {
                temp[j] = charArray[k];
                j++;
                k++;
            }
           temp[j] = charArray[charArray.Length - 1];
            Console.Write(temp);
        }

        public void BubbleSort(int []arrBubble)
        {
            int n = arrBubble.Length;
            try
            {
                
                for (int i = 0; i <n-1; i++)
                {
                    for (int j = 0; j <n-(i+1); j++)
                    {
                        if (arrBubble[j] < arrBubble[j + 1])
                        {
                            int temp = arrBubble[j];
                            arrBubble[j] = arrBubble[j + 1];
                            arrBubble[j + 1] = temp;
                        }
                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception is " + e);
            }

            for(int v=0;v<=n-1;v++)
            {
                Console.Write(arrBubble[v] + " ");
                Console.WriteLine();
            }
            
            
        }
        /***********************************************************************************/
        public void selectionSort(int [] arrInsertion)
        {
            int min, temp;
            int uppar = arrInsertion.Length;
            try
            {
                for (int outer = 0; outer <= uppar; outer++)
                {
                    min = outer;
                    for (int inner = outer + 1; inner <= uppar; inner++)
                    {
                        if (arrInsertion[inner] < arrInsertion[min])
                        {
                            min = inner;
                            Console.WriteLine("inner in if" + inner);
                            Console.WriteLine("min in if" + min);
                        }
                        temp = arrInsertion[outer];
                        arrInsertion[outer] = arrInsertion[min];
                        arrInsertion[min] = temp;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
            for (int v = 0; v <= uppar - 1; v++)
            {
                Console.Write(arrInsertion[v] + " ");
                Console.WriteLine();
            }
        }
        /*************************************************************************/
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else
                return gcd(b % a, a);
        }

        public static int findGCD(int[] x)
        {
            int len = x.Length;
            int result = x[0];
            for (int i = 1; i < len; i++)
                result = gcd(x[i], result);
            if (result == 1)
            {
                return 1;
            }
            return result;
        }
        /************************************************************************/


        public int binary(int[] a, int f, int l, int r)
        {
            if (r >= l)
            {
                int mid = (r + l) / 2;
                if (a[mid] == f)
                {
                    return mid;
                }
                if (f > a[mid])
                    return binary(a, f, l, mid + 1);
                return binary(a, f, l, mid - 1);
            }
            return -1;


        }

        /**************************************************************************/

        public int fibo(int number)
        {
            int num1 = 0;
            int num2 = 1;

            int sum = 1;
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 3; i <= number; i++)
            {
                int num3 = num1 + num2;
                sum = sum + num3;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + " ");
            }

            return sum;

        }

        /*****************************************************************************/

        public void duplicateWord(string msg)
        {
            /*************************using LINQ********************************/
            // string tempMsg = string.Join(" ", msg.Split(' ').Distinct());
            //Console.Write(tempMsg);
            /**********************************************************/
            HashSet<string> msgGroup = new HashSet<string>();

            string[] tempMsg = msg.Split(' ', '.', ',');
            for (int i = 0; i < tempMsg.Length; i++)
            {
                msgGroup.Add(tempMsg[i]);

            }
            foreach (var a in msgGroup)
            {

                Console.WriteLine(a);
            }


        }
    }
}
