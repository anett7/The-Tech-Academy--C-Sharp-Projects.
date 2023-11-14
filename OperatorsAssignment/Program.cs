using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
            //createing employee objects
        {
            Employee emp1 = new Employee() { FirstName = "Lilly", LastName= "Stein"};
            Employee emp2 = new Employee() { FirstName = "Ben", LastName = "Kiss" };
           emp1.Id =1;
           emp2.Id = 2;


        }
    }
}
