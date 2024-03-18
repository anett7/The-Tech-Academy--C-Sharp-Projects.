using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {

                var stud = new Student() { StudentName = "Billy" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
