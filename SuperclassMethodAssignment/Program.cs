using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperclassMethodAssignment
{
     class Program
    {
        static void Main(string[] args)
            // Inside main method instantiate and initialize an Employee object with first name:sample last name:student
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();

        }
        //Polymorphism assignment: use polymorphism to create an object that is of an interface type, use an object
        //that inherits from that interface 
        IQuittable quitter = new Employee();
    }
}
