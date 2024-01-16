using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            //Console.WriteLine(studentName);

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            //Console.WriteLine(courseName);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            //Console.WriteLine(pageNum);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string needHelp = Console.ReadLine();
            bool yesNo = bool.Parse(needHelp); //"convert the specified string representation of a logical value to its Boolean equivalent".

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string shareExperiance = Console.ReadLine();
            //Console.WriteLine(shareExperiance);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine(); //Using the string variable because the answers will be in unicode characters.
            //Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int studyHour = Convert.ToInt32(hoursStudy); // output would be the hours someone study.
            //Console.WriteLine(studyHour);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! This is the end of the program.");

            Console.ReadLine();
        }
    }
}
