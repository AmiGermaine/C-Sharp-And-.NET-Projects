 using System;
using System.Collections.Generic;


 class Program
 {
    static void Main()
    {
            
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}; //one-dimensional Array of strings
        Console.WriteLine("Please enter a number between 0 to 6");
        int index =Convert.ToInt32(Console.ReadLine());       
        Console.WriteLine(weekDays[index]);

        int[] numArray = { 5, 8, 9, 4, 2 }; //Array of integers with an if/else statements 
        Console.WriteLine("Please enter a number between 0 to 4");
        int index0 = Convert.ToInt32(Console.ReadLine());
        if (index0 < 0 || index0 > 4)
        {
            Console.WriteLine("the number that your enter doesn’t exist.");
        }
        else
        {
            Console.WriteLine(numArray[index0]);
        }

        List<string> fruit = new List<string> { "apple", "banana", "cherry" }; //Creating a list of string to dispay once the user select an array
        Console.WriteLine("Pick a number between 0 & 2");
        int index1 = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine(fruit[index1]);       


        Console.ReadLine();
    }
 }

