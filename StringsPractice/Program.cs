using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";
            int lengthOfName = firstName.Length;
            Console.WriteLine(lengthOfName);

            string myFaveQuote = ("\"It's a yam sham\" - Buffy Summers");
            Console.WriteLine(myFaveQuote);

            string escapeString = "I want a tab after this line \t I want a new line without WriteLine \n Hi";
            string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            Console.WriteLine(escapeString);
            Console.WriteLine(escapeString2);

            Console.WriteLine("User one, please type something");
            string userOneInput = Console.ReadLine();
            Console.WriteLine("User two, please type something");
            string userTwoInput = Console.ReadLine();

            if (userOneInput == userTwoInput)
            {
                Console.WriteLine("User 2 is a copy cat!");
            }
            else
            {
                Console.WriteLine("Way to be original!");
            }

            string startOfSentance = "My best friends name is ";
            string endOfSentance = "Charles";

            Console.WriteLine(startOfSentance + endOfSentance);
            Console.WriteLine("My friend {0} has a cute kid", endOfSentance);

            Console.WriteLine("This is a tab. \t \nThis is a backslash \\.\nAnd this is a bell sound. \a");

            Console.WriteLine("Please enter your first name.");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string sName = Console.ReadLine();

            Console.WriteLine(fName + " " + fName.Length);
            Console.WriteLine(sName + " " + sName.Length);

            if (fName.Length > sName.Length)
            {
                Console.WriteLine("First is longer.");
            }
            else if (fName.Length == sName.Length)
            {
                Console.WriteLine("Samsis?");
            }
            else
            {
                Console.WriteLine("Last must be longer");
            }

            Console.WriteLine("Please enter your first name.");
            string fMatchName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string sMatchName = Console.ReadLine();

            bool matching = (fMatchName == sMatchName);

            switch (matching)
            {
                case true:
                    Console.WriteLine("These names are the same");
                    break;
                case false:
                    Console.WriteLine("These names are different");
                    break;

            }

        }
    }
}
