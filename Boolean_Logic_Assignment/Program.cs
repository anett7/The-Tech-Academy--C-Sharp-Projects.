using System;


namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Car Insuarance Application");
                Console.WriteLine("What is your age?");

                string yourAge = Console.ReadLine();
                Console.WriteLine("Have you ever had a DUI, yer or no?");
                string answer = Console.ReadLine().ToLower();
                bool DUI = answer== "yes";
                Console.WriteLine("How many speeding tickets do you have?");
                string nrTickets = Console.ReadLine();

                bool qualified= (Convert.ToInt32(yourAge)>15 &&!DUI && Convert.ToInt32(nrTickets)<=3);
               Console.WriteLine("qualified for car insuarance? true or false:"+  qualified );
                Console.ReadLine();



          
                   
                

            
               
            }
        }
    }
}
