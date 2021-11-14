using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.CodeFirstDemo
{
    class Student
    {
        [Key]
        public int StudentRoll { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        
    }
}
