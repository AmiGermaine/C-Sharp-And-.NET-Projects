using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        public enum Days //Creating an enum for the days of the week.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try //try/catch block incase an error occurs
            {
                
                Console.WriteLine("Please enter the current day of the week?"); //user input
                string dayEnter = Console.ReadLine();
                Days  days = (Days)Enum.Parse(typeof(Days), dayEnter); //Assigning value to a variable of that enum data type 
                Console.WriteLine(days);
                
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                //return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
