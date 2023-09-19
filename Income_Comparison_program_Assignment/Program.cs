using System;
namespace Income_Comparison_program_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymus Income Comparison Program");             
            Console.WriteLine("Person1");            
            Console.WriteLine("Please add hourly_Rate of Person1:");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Number of hours worked per week?");
            string NmbrOfHours1 = Console.ReadLine();
            int annual_Salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(NmbrOfHours1) * 52;

            Console.WriteLine("Person2");
            Console.WriteLine("Please add hourly_Rate of Person2:");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Number of hours worked per week?");
            string NmbrOfHours2 = Console.ReadLine();

            int annual_Salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(NmbrOfHours2) * 52;
            Console.WriteLine("Annual salary of Person1:" + annual_Salary1);
            Console.WriteLine("Annual salary of Person2:" + annual_Salary2);
            bool comparison = annual_Salary1 >= annual_Salary2;
            Console.WriteLine("Person1 makes more money than person2 is:"+ comparison);
            Console.ReadLine();
        }
    }
}
