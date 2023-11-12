using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperclassMethodAssignment
{
    //create another class Employee and have it inherit from the Person class
    // Polymorphism Assignment:have your Employee class inherit the interface 
    public class Employee : Person, IQuittable
    {
        //give the Employee class a property called ID and have it be of data type int.
        public int Id { get; set; }
//Implement the SayName() method inside of the Employee class
    public override void SayName() 
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
        // Polymorphism Assignment:implement the Quit Method
        public void Quit(Employee employee) 
        {
            Console.WriteLine();
        }
    }
}
