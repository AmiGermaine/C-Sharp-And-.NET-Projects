using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 8, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            bool numVal = false;
            while (!numVal) 
            {
                try //try/catch expection to catch errors that'll occur during execution 
                {
                    Console.WriteLine("Enter a number:");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    if (numOne == 0)
                    {
                        Console.WriteLine("Can't enter zero");
                    }
                    else
                    {
                        foreach (int i in numbers)
                        {
                            int divideresult = i / numOne;
                            Console.WriteLine(i + " divide " + numOne + " equal " + divideresult);
                        }
                        numVal = true;
                    }

                }
                catch (FormatException ex) //statement that will handle an expection when it occur
                {
                    Console.WriteLine("Please Enter numbers ONLY!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Can't divide by zero");
                }

                catch (Exception ex)  //Catch exception to catch everything
                {
                    Console.WriteLine(ex.Message);
                }
                finally //finally block to excute the code regardless if an exception is caught or not
                {
                    Console.ReadLine();
                }
            }
           
        }
    }
}
