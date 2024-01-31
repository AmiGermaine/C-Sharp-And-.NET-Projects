using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;



class Program
{
    static void Main(string[] args)
    {



        // Assignment part 1 one-dimensional array of strings.
        String[] pets = { "dog", "cat", "goldfish", "snake", "bird" };

        string[] toys = { "bone", "tennis ball", "catnip", "tuffy", "frisbee" };

        List<string> responses = new List<string>();
        Console.WriteLine("Please enter a text.");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter a toy.");
        responses.Add(Console.ReadLine());
        for (int i = 0; i < pets.Length; i++)
        {
            string newPet = pets[i] += responses;
            Console.WriteLine(newPet + toys[i]);
        }

        // Assignment part 2 & 3, Infinite loop.
        //int j = 0;

        //while (j < toys.Length)
        //{
        //    Console.WriteLine(toys[j]);
        //    j++;
        //}
        var j = 0;
        while (true)
        {
            Console.Write("Enter a number (or 'ok' to exit): ");
            var input = Console.ReadLine();

            if (input.ToLower() == "ok")
                break;

            j += Convert.ToInt32(input);
        }

        // Assignment part 4





        Console.ReadLine();

    }    
}

