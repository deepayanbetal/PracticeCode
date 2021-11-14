using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.LinqPractice
{
    class Student

    {

        public int StudentId { get; set; }

        public string Name { get; set; }

        public int Marks { get; set; }

        public static List<Student> getStudent()
        {
            List<Student> students = new List<Student>()
        {
            new Student(){StudentId=1,Name="Jack",Marks=40},
            new Student(){StudentId=2,Name="Sparow",Marks=50},
            new Student(){StudentId=3,Name="Rose",Marks=60},
            new Student(){StudentId=4,Name="Renu",Marks=90}
        };
            return students;
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string dept { get; set; }
        public List<string> role { get; set; }

        public static List<Employee> getEmployee()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=1,Name="Jhone",dept="ECE", role= new List<string>{"PA","Analyst"}},
                new Employee{Id=2,Name="Maxwell",dept="EE", role= new List<string>{"PAT","Analyst"}}
            };
            return emp;
        }
    }
    class LinqProjection
    {
        public void callStudent()
        {
            var result = (from s in Student.getStudent()
                                    select new { SName = s.Name, SID = s.StudentId, SMarks = s.Marks });

            foreach (var id in result)
            {
                Console.WriteLine("The StudentName is {0} ID is {1} Marks is {2}", id.SName, id.SID, id.SMarks);
            }

        }

        public void callEmployee()
        {
            var result = Employee.getEmployee().SelectMany(x=>x.role);

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
        }

        public void joinCall()
        {
            var result = from empObj in Employee.getEmployee()
                         join studObj in Student.getStudent() 
                         on empObj.Id equals studObj.StudentId
                         select new { studentName = studObj.Name, employyeDept = empObj.dept };
            foreach(var res in result)
            {
                Console.WriteLine(res.employyeDept + res.studentName);
            }

        }

        public void testLi()
        {
            using (Bike_StoreEntities2 BS = new Bike_StoreEntities2())
            {
                IEnumerable<brand> brands = new List<brand>();
                var que3 = from x in BS.brands
                           where x.brand_id == 1
                           select x;
                foreach(var a in que3)
                {
                    //Console.WriteLine(a.brand_name);
                }

                var que4 = from x in BS.orders
                           where x.customer_id == 22
                           select x;
                foreach(var vque4 in que4)
                {
                    Console.WriteLine("orderDates :"+vque4.order_date);
                }
            }
        }

        public void joincarCustomer()
        {
            using (Bike_StoreEntities2 BSE = new Bike_StoreEntities2())
            {
                
            }
        }

        public void crudInsertLinq()
        {
            using (employeeEntities5 ee = new employeeEntities5())
            {
                empInfo empInfoobj = new empInfo();
                empInfoobj.empid = 999;
                empInfoobj.ename = "sumi dutta";
                empInfoobj.dept = "sexworker";
                empInfoobj.mobile = "7777777";
                ee.empInfoes.Add(empInfoobj);
                ee.SaveChanges();
            }
        }

        public void updateCrudLinq()
        {
            using (employeeEntities5 ee = new employeeEntities5())
            {
                empInfo empInfoObj = ee.empInfoes.SingleOrDefault(id => id.empid == 999);
                empInfoObj.mobile = "55554444";
                ee.SaveChanges();
            }
        }

        public void deleteCrudLinq()
        {
            using (employeeEntities5 ee = new employeeEntities5())
            {
                empInfo empInfoobj = ee.empInfoes.SingleOrDefault(id=> id.empid==999);
                ee.empInfoes.Remove(empInfoobj);
                ee.SaveChanges();
            }
        }


       




    }

    

}
