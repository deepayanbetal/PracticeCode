using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeProgramms.TestDome
{





    

    public class DriverExam
    {
        public static void ExecuteExercise(IExercise exercise)
        {
            
            exercise.Start();
            exercise.End();
            if(exercise.Start() && exercise.Execute() == false)
            {
                exercise.MarkNegativePoints();
                Console.WriteLine("in If");
                exercise.End();
            }
        }
    }

    public interface IExercise
    {
        bool Start();
        bool Execute();
        void MarkNegativePoints();
        void End();
    }

    public class Exercise : IExercise
    {
        public bool Start() { Console.WriteLine("Start"); Boolean flag = true; return flag; }
        public bool Execute() { Console.WriteLine("Execute"); Boolean flag = true; return flag; }
        public void MarkNegativePoints() { Console.WriteLine("MarkNegativePoints"); }
        public void End() { Console.WriteLine("End"); }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        DriverExam.ExecuteExercise(new Exercise());
    //    }
    //}
}