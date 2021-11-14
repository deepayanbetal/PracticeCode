using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.QuickSort
{
    class QuickSortClass
    {
        public void qsort(int []x, int low, int high)
        {
            int pos;
            if(low<high)
            {
                pos = position(x, low, high);
                qsort(x, low, pos - 1);
                qsort(x, pos + 1, high);
            }
           
        }

        public int position( int []x, int low, int high)
        {
            int temp, flag = 1;
            int position = low;
            while(flag==1)
            {
                for(int i=high; i> position;i--)
                {
                    flag = 0;
                    if(x[position]>x[i])
                    {
                        temp = x[position];
                        x[position] = x[i];
                        x[i] = temp;
                        position = i;
                        flag = 1;
                        break;
                    }
                }

                if(flag==1)
                {
                    for (int i= 1;i< position;i ++)
                    {
                        flag = 0;
                        if(x[position]<x[i])
                        {
                            temp = x[position];
                            x[position] = x[i];
                            x[i] = temp;
                            position = i;
                            flag = 1;
                            break;
                        }
                    }
                }
            }
            return position;
        }
    }
}
