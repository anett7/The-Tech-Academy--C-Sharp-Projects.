using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the main() method, create a list of at least 10 employees. 
            //at least two should have the first name "Joe"
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {Id = 1, firstName= "Joe", lastName= "Storm"},
                new Employee() {Id = 2, firstName= "Joe", lastName= "Tom"},
                new Employee() {Id = 3, firstName= "George", lastName= "Con"},
                new Employee() {Id = 4, firstName= "Ann", lastName= "Tomas"},
                new Employee() {Id = 5, firstName= "Lilly", lastName= "Barkley"},
                new Employee() {Id = 6, firstName= "Ben", lastName= "Titly"},
                new Employee() {Id = 7, firstName= "Anna", lastName= "Joesephino"},
                new Employee() {Id = 8, firstName= "Joe", lastName= "Kiss"},
                new Employee() {Id = 9, firstName= "Bal", lastName= "Rade"},
                new Employee() {Id = 10, firstName= "Emy", lastName= "Lee"}

            };
            //using a foreach loop, create a new list of all employees with the first name JOe.
            List<Employee> joes = new List<Employee>();
            int index = 0;
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                    index++;
                }
            }
            Console.WriteLine(joes);
            Console.ReadLine();


            //Do the same thing again, but this time with labda expression
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId= campus.Where(x=> x.Id >5).ToList();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
