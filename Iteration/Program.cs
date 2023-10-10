using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        //Part 4 create a list of strings where each item in the list is unique
        List<string> students = new List<string> { "Kiss", "Stein", "Nagy", "Kovacs", "Soos" };
        //ask the user to input text to search for in the list.
        Console.WriteLine("Enter student's name");

        string studentinput = Console.ReadLine();
        for (int i = 0; i < students.Count; i++)
        {
            if (studentinput == students[i])
            {
                Console.WriteLine("that is a valid student name, it was found at index" + i);
            }
          
            else
             {
              i++;
             }
        }
        if (i == students.Count)
        {

            Console.WriteLine("that is not a valid student name, please write a valid student name!");

        }
        Console.ReadLine();
        
        
    }


}

