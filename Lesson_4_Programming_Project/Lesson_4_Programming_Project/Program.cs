using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Unit 1 lesson 4 Programming Project 
//ASCII Art Business Card
//written by Pranav Krovvidi
//Data Structures Period 5 
namespace Lesson_4_Programming_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting the data for the business card
            Console.Out.WriteLine("What is your full name:          ");
            String fullName = Console.In.ReadLine();
            Console.Out.WriteLine("What is your job title:           ");
            String jobTitle = Console.In.ReadLine();
            Console.Out.WriteLine("What is your email address:         ");
            String emailAddress = Console.In.ReadLine();
            Console.Out.WriteLine("What is your phone number:          ");
            try
            {
                int phoneNumber = int.Parse(Console.In.ReadLine());
                String format = "000-000-0000";
                //String phoneNumber = Console.In.ReadLine();
                Console.Out.WriteLine("What is your business address:        ");
                String businessAddress = Console.In.ReadLine();
                Console.Out.WriteLine("--------------------------------------------");
                //giving the business card back to the user 
                Console.Out.WriteLine(" |Full name:       " + fullName +"         |");
                Console.Out.WriteLine(" |Job Title:        " + jobTitle +"                |");
                Console.Out.WriteLine(" |Email Address:      " + emailAddress +"        |");
                Console.Out.WriteLine(" |Phone Number:          " + phoneNumber.ToString(format) +"      |");
                Console.Out.WriteLine(" |Business Address:      " + businessAddress +"    |");
                Console.Out.WriteLine("--------------------------------------------");
                Console.Out.WriteLine("Hit enter to close the program");
            }
            catch
            {
                Console.Out.WriteLine("Error invalid phone number");
                Console.Out.WriteLine("Hit enter to close the program");
            }
            Console.In.ReadLine();
        }
    }
}
