using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Text;
using System.Web;

class Program
{
    static void Main(string[] args)
    {
        //int[]testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94};

        //for (int i=0; i< testScores.Length; i++)
        //{
        //    if (testScores[i]> 85)
        //    {
        //        Console.WriteLine("Passing test score:" + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
        //for ( int j = 0; j < names.Length; j++ )
        //{
        //    if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores) 
        //    {
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
        //foreach (string name in names)
        //{
        //    if (name== "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 23, 99, 12, 74, 23, 99 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score>85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}
        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();


        // Console app assignment part 1
        //create a one - dimensional Array of Strings

        //string[] sentence_start = { "My favorite color is: ", "I love eating: ", "My best friend is:" };
        ////ask user to input some text:
        //List<string> responses = new List<string>();
        //Console.WriteLine("Please enter your favorite color");
        //responses.Add(Console.ReadLine());
        //Console.WriteLine("Please enter a food you like");
        //responses.Add(Console.ReadLine());
        //Console.WriteLine("Please enter a friend's name that comes first in your mind");
        //responses.Add(Console.ReadLine());

        ////create a loop that goes through each string in the array, adding user's text to string and print this on separate lines.
        //for (; ; )//(int j = 0; j < sentence_start.Length; j++)
        //{

        //    Console.WriteLine(sentence_start[j] + responses[j]);
        //}
        //Console.ReadLine();

        ////part 2
        ////create an infinite loop, fix it
        //bool control = true;
        //while (control)
        //{
        //    Console.WriteLine("the control is true");


        //    //update control variable to stop the infinite loop
        //    control = false;
        //    Console.ReadLine();
        //}
        //Part 3
        //add a loop where the comparison that is used to determine whether to continue iterating
        // is a <+ opearator.

        //StringBuilder ahh = new StringBuilder();
        //ahh.Append("A");
        //while (ahh.Length <=10)
        //    {
        //    ahh.Append("h");
        //            }
        //ahh.Append("!");
        //Console.WriteLine(ahh);
        //Console.ReadLine();

        ////Part 4 create a list of strings where each item in the list is unique
        //List<string> students = new List<string> { "Kiss", "Stein", "Nagy", "Kovacs", "Soos" };
        ////ask the user to input text to search for in the list.
        //Console.WriteLine("Enter student's name");

        //string studentinput = Console.ReadLine();
        //int index = 0;
        //foreach (string item in students)
        //{
        //    if (studentinput == item)
        //    {
        //        Console.WriteLine("that is valid student name, it was found at index" + index);
        //        index++;
        //    }



        //    else
        //    {
        //        Console.WriteLine("that is not a valid student name, please write a valid student name!");
        //        index++;
        //    }

        //}
        //Console.ReadLine();

        ////Part 4 create a list of strings where each item in the list is unique
        //List<string> students = new List<string> { "Kiss", "Stein", "Nagy", "Kovacs", "Soos" };
        ////ask the user to input text to search for in the list.
        //Console.WriteLine("Enter student's name");

        //string studentinput = Console.ReadLine();
        //for (int i = 0; i < students.Count; i++)
        //{
        //    if (studentinput == students[i])
        //    {
        //        Console.WriteLine("that is a valid student name, it was found at index" + i);
        //    }

        //    else
        //     {
        //      index++;
        //     }
        //}
        //if (index == students.Count)
        //{

        //    Console.WriteLine("that is not a valid student name, please write a valid student name!");

        //}
        //Console.ReadLine();



        //////part 5. 
        ////Create a list of strings that has at least two identical strings in the list.
        //List<string> tables = new List<string> { "Reserved", "Vacant", "Taken", "Taken", "Vacant", "Reserved" };
        //Console.WriteLine("Welcome to OUR Caffe check in.\nIf you have a reservation, type \"Reserved\".\nIf you join a party, type\"Taken\". \nOtherwise type\"Vacant\".");

        ////ask user to select text
        //Console.WriteLine("Enter selection:");
        //    string selection = Console.ReadLine();
        ////add code that tells user if input is not on the list
        //while (!(selection== "Vacant" || selection== "Reserved" || selection=="Taken"))
        //{
        //    Console.WriteLine("Please enter one of 3 choices:");
        //    selection = Console.ReadLine();
        //}
        //Console.WriteLine("Our tables are numbered, that matches your selection:");
        ////create loop that iterates through the loop and displays indices of the array that contain matching text on the screen.

        //for (int i3 =0; i3< tables.Count; i3++)
        //{
        //    if (selection == tables[i3])
        //    {
        //        Console.WriteLine(i3);
        //    }
        //}
        //Console.ReadLine();
        ////end of part5
        ///

        //Part 6
        //list of strings that has two identical strings in the list. 
        List<string> students = new List<string> { "Mary", "Ann", "Anita", "Anna", "Anita" };
        List<string> repeatCheck = new List<string>();
        Console.WriteLine("Class Roster:");
        //Create foreach loop to evaluate each item in the list display a message showing the string and whether or not it has already appeared

        foreach (string name in students)
        {
            Console.WriteLine(name);
            if (repeatCheck.Contains(name))
            {
                Console.WriteLine("this name has been repeated, use last name initial");
            }
            else
            {
                Console.WriteLine("This name has not been repeated");
            }
            repeatCheck.Add(name);
        }
        Console.ReadLine();
        
    }
   


}

