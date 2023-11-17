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
            Employee emp1 = new Employee() { Id=1, FirstName = "Lilly", LastName= "Stein"};
            Employee emp2 = new Employee() { Id=2, FirstName = "Ben", LastName = "Kiss" };

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp2);
            Console.ReadLine();
           


        }
    }
}
