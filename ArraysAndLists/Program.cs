using System;
using System.Collections.Generic;




    class Program
    {
    static void Main()
    {
        // we create a list:
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //intList.Remove("Jesse");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //Three diff wayS to create an array:

        //VARIANT ONE:
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //VARIANT TWO:

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 500 };

        //VARIANT THREE:
        //int[] numArray2 = { 5, 2, 10, 200, 500 };

        ////to change the 4th in the array from 500 to 650:

        //numArray2[4] = 650;
        //Console.WriteLine(numArray2[4]);
        //Console.ReadLine();

        //create an array of integers
        int[] numArray1 = new int[] { 5, 2, 10, 200, 500, 2000 };
        //ask user for a number to display the number at that index
        Console.WriteLine("Select a number between 0 and 5!");
        int indexNumb = Convert.ToInt32(Console.ReadLine());
        bool validInt = true;

        while (validInt) 
        {
            try
            {
                Console.WriteLine("Your lucky number is " + numArray1[indexNumb]);
                validInt = false;
                Console.ReadLine();
                
            }
            //Add a message to say if user picks non-existing index
            catch {
                Console.WriteLine("Sorry, your selection is not valid, select a number between 0 and 5.");
                 indexNumb = Convert.ToInt32(Console.ReadLine());
            }
        }

        //create an array of strings
        string[] stringArray = new string[] { "red", "blue", "white", "black", "green", "purple" };
        //ask user for a number to display the color at that index
        Console.WriteLine("Select a number between 0 and 5!");
        int indexNumberString = Convert.ToInt32(Console.ReadLine());
        bool validIndex = true;

        while (validIndex)
        {
            try
            {
                Console.WriteLine("Your favorite color is " + stringArray[indexNumberString]);
                validIndex = false;
                Console.ReadLine();

            }
            //Add a message to say if user picks non-existing index
            catch
            {
                Console.WriteLine("Sorry, your selection is not valid, select a number between 0 and 5.");
                indexNumberString = Convert.ToInt32(Console.ReadLine());
            }
        }
        //List of strings
        List<string> occupationList = new List<string>()
        {
            "Teacher", "Gymnast", "Therapist", "Data Analyst", "Fencer", "journalist"
        };
        //ask user for a number
        Console.WriteLine("Select a number between 0 and 5!");
        int listSelect = Convert.ToInt32(Console.ReadLine());
        bool validList = false;

        while (!validList)
        {
            try
            {
                Console.WriteLine("Your matching occupation is " + occupationList[listSelect]);
                validList = true;
                Console.ReadLine();

            }
            //Add a message to say if user picks non-existing index
            catch
            {
                Console.WriteLine("Sorry, your selection is not valid, select a number between 0 and 5.");
                indexNumberString = Convert.ToInt32(Console.ReadLine());
            }
        }



    }

}

