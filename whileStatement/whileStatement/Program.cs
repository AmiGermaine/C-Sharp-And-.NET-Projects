using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace whileStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Birth month in number form?");
            int BDmonth = Convert.ToInt32(Console.ReadLine());
            bool guess = BDmonth == 5; //comparison expression for true or false

            do //Do while loop to execute the code at least once
            {
                // switch statement
                switch (BDmonth)
                {
                    case 1:
                        Console.WriteLine("You picked 1. it is not January");
                        Console.WriteLine("Pick a Birth month in number form?");
                        BDmonth = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("You picked 2. it is not Febuary");
                        Console.WriteLine("Pick a Birth month in number form?");
                        BDmonth = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("You picked 3. it is not March");
                        Console.WriteLine("Pick a Birth month in number form?");
                        BDmonth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You picked 4. it is not April");
                        Console.WriteLine("Pick a Birth month in number form?");
                        BDmonth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You picked 5. May is correct");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("That is cool month for a Birthday too!");
                        Console.WriteLine("Pick a Birth month in number form?");
                        BDmonth = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guess); //while loop loops through the code as long the specified condition hold true        
            
            Console.ReadLine();
        }
    }
}
