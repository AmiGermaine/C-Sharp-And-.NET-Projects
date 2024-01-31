using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;


internal class Program
{
    static void Main(string[] args)
    {
        //Part 1.Creating a one -dimensional Array of strings.

        string[] greetings = { "Hello", "Bonjour", "hola" };
       
        Console.WriteLine("Please enter a text:");
        string responses = Console.ReadLine();
        for (int i = 0; i < greetings.Length; i++)
        {
            greetings[i] += responses;
            Console.WriteLine(greetings[i]);
        }
        //Console.ReadLine();
        //Console.WriteLine("How are you?");
        //for (int i = 0; i < greetings.Length; i++)
        //{
        //    Console.WriteLine(greetings[i]);
        //}
        //Console.ReadLine();

        //Part 2.Creating an infinite Loop

        string sentence = "";

        while (sentence == "") // while loop will repeat the code while some condition remains true infinitely 
                               //until condition becomess false
        {
            Console.WriteLine("Please enter another text:"); //as long the user does not input anything in the console the "Please enter another text:" will continue to display
            sentence = Console.ReadLine();  
        }
        Console.WriteLine("oh" + sentence);

        //part 3. comparison of "<" and "<=" operators
        int run = 0;
        while (run < 10) {
            run += 1;
            Console.WriteLine(run);
        }
        int time = 0;
        while (time <= 10)
        {
            time += 1;
            Console.WriteLine(time);
        }    

        // part 4. a list of string where each item in the list is unique 

        List<string> uniqueItems = new List<string>() { "Happy", "Smile", "Sad"};
        Console.WriteLine("Please input text to search in the list: ");
        string userItem = Console.ReadLine();
        Console.WriteLine("Your pick is:" + userItem);
        for (int j = 0; j < uniqueItems.Count; j++)
        {
            //string lookingAt = uniqueItems[j];
            if (userItem == uniqueItems[j])
            {
                Console.WriteLine("Found it at index " + j);
                break; //exit the loop early
            }
            else if (!uniqueItems.Contains(userItem)) 
            {
                Console.WriteLine("Your text is not on the list ");
                break; //exit the loop earlybreak; 
            }
        }
        //part 5. A list of strings that has at least two identical strings.

        List<string> duplicateItem = new List<string>() { "Happy", "Smile", "Sad", "Sad" };
        Console.WriteLine("Please input text to search in the list: ");
        userItem = Console.ReadLine();
        Console.WriteLine("Your pick is:" + userItem);
        for (int j = 0; j < duplicateItem.Count; j++) //A loop that iterates through the list and then displays the indices of the items matching the user-selected text
        {
            if (userItem == duplicateItem[j])
            {
                Console.WriteLine(duplicateItem[j] + " Found it at index " + j);
               
            }
            else if (!duplicateItem.Contains(userItem)) //Check if the user put in text that isn't on the list
            {
                Console.WriteLine("Your text is not on the list ");
                break; //exit the loop early
            }
        }

        // Part 6. A foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.

        List<string> duplicate = new List<string>() { "warm", "cold", "warm", "not so cold" };
        List<string> output = new List<string>();
        
        foreach (string item in duplicate)
        {
            if (output.Contains(item)) {
                Console.WriteLine(" This item is a duplicate");
            }
            else { output.Add(item);
                Console.WriteLine("This is unique");
            }           
        }

        Console.ReadLine();
    }
 }

