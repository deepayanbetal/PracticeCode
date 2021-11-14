using PracticeProgramms.ADOPrac;
using PracticeProgramms.DelegateDemo;
using PracticeProgramms.DelInterview;
using PracticeProgramms.EventTrial;
using PracticeProgramms.LinqPractice;
using PracticeProgramms.OldCodesPractice;
using PracticeProgramms.QuickSort;
using PracticeProgramms.RefOutDemo;
using PracticeProgramms.SingletonEg;
using PracticeProgramms.StartPattern;
using PracticeProgramms.TestDome;
using PracticeProgramms.UpCasting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Demo d = new Demo();
            //d.caller();
            // DemoClass dc = new DemoClass();
            //dc.caller();

            // int[] array = { 2, 1, 5, 60, 7, 4 };
            //QuickSortClass QC = new QuickSortClass();
            //QC.qsort(array,0,5);
            //Console.WriteLine(array);
            //int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            //int n = 10, i;
            //Console.WriteLine("Quick Sort");
            //Console.Write("Initial array is: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //QC.qsort(arr, 0, 9);
            //Console.Write("\nSorted Array is: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            // LinqProjection LP = new LinqProjection();
            //LP.callStudent();
            //LP.callEmployee();
            //LP.joinCall();
            //LP.testLi();
            //LP.crudInsertLinq();
            // LP.updateCrudLinq();
            //LP.deleteCrudLinq();

            //StarPattern SP = new StarPattern();
            //SP.designStar(5);
            //SP.starPatternUpwords(5);
            //SP.pyramidPattern(5);


            // DriverExam DE = new DriverExam();
            //DriverExam.ExecuteExercise(new Exercise());

            //MyDelegate del = DelegateClass.methodOne;
            //del("from method one");

            //del = ClassB.methodTwo;
            //del("from class two");

            //MySecondDelegate mySecondDelegate;
            //mySecondDelegate = DelegateClass.newDelegateMethod;
            //mySecondDelegate(66);

            //EventClass EC = new EventClass();
            //EC.ProcessComplete += EC_ProcessComplete;
            //EC.StartEvent();

            //UpCastings UP = new UpCastings(10,20);/*** UpCaseting ***/
            //UpCastings Squares = new Square(30,40);
            //UpCastings Circles = new Circle(50,60);
            //Circle c = (Circle)Circles;/** Down casting**/

            //UP.Draw();
            //Squares.Draw();
            //Circles.Draw();
            //c.fillColor();/** Down casting**/


            //SingletonClass SC3 = SingletonClass.GetSingleton();
            //SingletonClass SC4 = SingletonClass.GetSingleton();
            //SingletonClass SC = new SingletonClass();
            //SingletonClass SC2 = new SingletonClass();

            //SC.singletonmethod("msg from pussy");
            //SC2.singletonmethod("msg from boobs");

            //SC3.singletonmethod("msg from first user of the object");
            //SC4.singletonmethod("msg from second user of the object");


            // int[] arr1 = new int[]{800,7,7000,8,2,4};
            //OldClass old = new OldClass();
            // old.starPattern(5);
            // old.reversePattern(5);
            // old.charCount("nice time to be");
            //old.eliminatetrapace("nice time to suck, i like you suck me, so suck suck suck");
            //old.spaceCount("space counting sentence");
            //old.Abbriviation("ram kumar das");
            // old.BubbleSort(arr1);
            //old.selectionSort(arr1);


            ADOPrac1 ad = new ADOPrac1();
            ad.connectionDB();
            








        }

        //private static void EC_ProcessComplete()
        //{
        //    int i = 0;
        //    while(true)
        //    {
        //        if(i<1000)
        //        {
        //            Console.WriteLine(i++);
        //        }
        //        else
        //        {
        //            break;
        //        }

        //    }
        //}


        
        
    }
}
