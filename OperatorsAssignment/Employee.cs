using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        //create an Employee class with Id, FirstName, LastName properties.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // overload == operator so it checks if two employee objects are equal by comparing their Id property
        //overloaded in pairs
        Public static bool operator == (Employee emp1, Employee emp2)
             {
            return emp1.Id == emp2.Id;
             }
        PublicKey static bool operator != (Employee emp1, Employee emp2)
            {
            return emp1.Id != emp2.Id;
            }

    }
}
