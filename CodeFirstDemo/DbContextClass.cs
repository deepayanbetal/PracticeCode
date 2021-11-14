using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramms.CodeFirstDemo
{
    class DbContextClass : DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}
