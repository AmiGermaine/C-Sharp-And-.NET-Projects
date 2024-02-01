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
            
            try //try/catch expection to catch errors that'll occur during execution 
            {
                List<int> numbers = new List<int>() { 2, 4, 6, 8, 10 };
                Console.WriteLine("Enter a number:");
                int numOne = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter a second number.");
                //int numTwo = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Dividing the two...");
                //int numThree = numbers / numOne;
                Console.WriteLine("result is: " + numThree );
                
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
