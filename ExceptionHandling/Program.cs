using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Pick a number.");
        //    int numberOne = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Pick a second number.");
        //    int numberTwo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Divideng the two...");
        //    int numberThree = numberOne / numberTwo;
        //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //    Console.ReadLine();
        //}
        //catch (FormatException ex) 
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (DivideByZeroException ex) 
        //{
        //    Console.WriteLine("Please don't divide by zero");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //Console.ReadLine();

        try
        {
            
            List<int> listIntegers = new List<int>();
            listIntegers.Add(12);
            listIntegers.Add(22);    
            listIntegers.Add(32);
            listIntegers.Add(41);                
            listIntegers.Add(8);
            listIntegers.Add(6);
            listIntegers.Add(2);
            
            Console.WriteLine("Pick a number to divide each number in the list.");
            int numberSelected = Convert.ToInt32(Console.ReadLine());
            int index = 0;

            foreach (int element in listIntegers) 
            {
            
                int result = element / numberSelected;
                Console.WriteLine( index + " number divided by" + numberSelected + "equals" + result);
                index++;
            }

            
                      
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}

