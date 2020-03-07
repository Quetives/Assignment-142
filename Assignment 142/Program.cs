using System;
using System.Collections.Generic;

namespace Assignment_142
{
    class Program
    {
        static void Main()
        {
            // Step 1. Assignment 142======================================================================================
            //String addName;
            //string[] names = new string[3] { "Richard", "Anthony", "Quetives" };

            //Console.WriteLine("Please type YEAH!:");
            //addName = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Here is my name.");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name + ", " + addName);
            //}
            //Console.WriteLine("Are you pumped up!... " + addName);
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            // Step 2. INFINITE LOOP========================================================================================
            //for (int a = 0; a < 50; a--)
            //    {
            //        Console.WriteLine("Value : {0}", a);
            //    }
            //    Console.ReadLine();

            // Step 3. INFINITE LOOP CORRECTED==========================================================================
            //for (int a = 0; a <= 50; a++)
            //{
            //    Console.WriteLine("Value : {0}", a);
            //}
            //Console.ReadLine();

            // Step 4 LOOP with < Comparison===========================================================================
            //for (int b = 0; b < 10; b++)
            //{
            //    Console.WriteLine(b);
            //}
            //Console.ReadLine();

            // Step 5 LOOP with <= Comparison===========================================================================
            //for (int c = 0; c <= 10; c++)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.ReadLine();

            // Step 6-8=====================================================================================================
            //string error = null;
            //string color;
            //List<string> colors = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            //Console.WriteLine("Search through the list to find a color:");
            //color = Console.ReadLine();

            //for (int i = 0; i < colors.Count; i++)
            //{
            //    if (colors[i].Contains(color))
            //    {
            //        Console.WriteLine(colors[i] + " is at index #" +i);
            //        break;
            //    } else if (colors[i].Contains(color) == false)
            //    {
            //        error = "Color Not Found";
            //    }    
            //}
            //string Result = error == null ? "Thanks for choosing."  : error;
            //Console.WriteLine(Result);
            //Console.ReadLine();

            //Step 9-10
            //string choice;
            //List<string> color = new List<string>() { "Red", "Orange", "Red", "Orange", "Blue", "Indigo", "Blue" };
            //Console.WriteLine("Enter one of these colors: Red, Orange, Blue or Indigo.");
            //choice = Console.ReadLine();

            //for (int a = 0; a < color.Count; a++)
            //{
            //    if (color[a].Contains(choice))
            //    {
            //        Console.WriteLine(color[a] + " is at index " + a);
            //    }
            //    else if (choice != "Red" || choice == "Orange" || choice == "Blue" || choice == "Indigo")
            //    {
            //        Console.WriteLine("Does not match color List");
            //    }
            //}
            //Console.ReadLine();

            List<string> colors = new List<string>() { "Red", "Orange", "Yellow", "Yellow", "Green", "Blue", "Indigo", "Violet", "Red" };

            List<string> myList = new List<string>();
            List<string> duplicates = new List<string>();

            foreach (string color in colors)
            {
                if (!myList.Contains(color))
                {
                    myList.Add(color);
                }
                else
                {
                    duplicates.Add(color);
                }

            }

            Console.WriteLine("Here are the items in the list.");
            Console.WriteLine(string.Join(", ", myList));
            Console.WriteLine("Here are the duplicate entries in the list.");
            Console.WriteLine(string.Join(", ", duplicates));
            Console.WriteLine("Here is the list as it is.");
            Console.WriteLine(string.Join(", ", colors));
            Console.ReadLine();
        }
    }
}
