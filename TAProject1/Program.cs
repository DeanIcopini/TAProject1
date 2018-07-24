using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAProject1
{
    class Program
    {
        static void Main()
        {
            /*Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();*/

            // Start the program by printing "The Tech Academy"
            Console.Write("The Tech Academy \n");
            
            // Next print "Student Daily Report"
            Console.WriteLine("Student Daily Report. \n" + "press enter key to continue");
            Console.ReadLine();

            // Ask and Save to a well named variable and proper data type answers to questions
            // What course are you on? What page number? Do you need help with anything?(true or false)
            // Were there any positive experiences you'd like to share? Please give specifics.
            // How many hours did you study?
            Console.WriteLine("What course are you on? ");
            string courseName = Console.ReadLine();
            
            Console.WriteLine("What page number are you on? ");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? " + "Please answer true or false.");
            string helpTF = Console.ReadLine();
            bool help = Convert.ToBoolean(helpTF);

            Console.WriteLine("Were there any positive experiences you'd like to share? " + "Please give specifics.");
            string expToShare = Console.ReadLine();

            Console.WriteLine("How many hours did you study? ");
            string studyHours = Console.ReadLine();
            ushort hours = Convert.ToUInt16(studyHours);

            Console.WriteLine("Good work on studying " + studyHours + " hours!");
            Console.ReadLine();

            // After all of the questions are asked, print "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"
            Console.WriteLine("Thank you for your answers. " + "An Instuctor will respond to this shortly. \n" + "Have a great day!");
            Console.ReadLine();

        }
    }
}
