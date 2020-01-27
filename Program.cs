using System;
using System.Text.RegularExpressions;

namespace Regular_Expression_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isName = false;
            while (!isName)
            {
                string userInput = GetUserInput("Enter a name! (or type 'e' to exit): ");
                if (CheckIfName(userInput) == true)
                {
                    Console.WriteLine("That's a name!");
                    isName = true;
                }
                else if (userInput[0] == 'e')
                {
                    isName = true;
                }
                else
                {
                    Console.WriteLine("Not a valid format.");
                    isName = false;
                }

            }
            bool isEmail = false;
            while (!isEmail)
            {
                string userInput = GetUserInput("Enter an email now (or type 'e' to exit): ");
                if (CheckIfEmail(userInput) == true)
                {
                    Console.WriteLine("That's a valid email!");
                    isEmail = true;
                }
                else if (userInput[0] == 'e')
                {
                    isEmail = true;
                }
                else
                {
                    Console.WriteLine("Not a valid format.");
                    isEmail = false;
                }
            }
            bool isPhoneNumber = false;
            while (!isPhoneNumber)
            {
                string userInput = GetUserInput("Now enter a phone number with this format: 777-777-7777. Type 'e' to exit:");
                if (CheckIfPhoneNumber(userInput) == true)
                {
                    Console.WriteLine("That's a valid phone number!");
                    isPhoneNumber = true;
                }
                else if (userInput[0] == 'e')
                {
                    isPhoneNumber = true;
                }
                else
                {
                    Console.WriteLine("Not a valid format.");
                    isPhoneNumber = false;
                }
            }
            bool isValidDate = false;
            while (!isValidDate)
            {
                string userInput = GetUserInput("Now enter a birthdate in this format (dd/mm/yyyy). Type 'e' to exit.");
                if (CheckIfValidDate(userInput) == true)
                {
                    Console.WriteLine("That's a valid date!");
                    isValidDate = true;
                }
                else if (userInput[0] == 'e')
                {
                    isValidDate = true;
                }
                else
                {
                    Console.WriteLine("Not a valid format.");

                }
            }

            bool isValidHTML = false;
            while (!isValidHTML)
            {
                string userInput = GetUserInput("Now enter an HTML line with a opening and closing tag (Ex. <a></a>. Type 'e' to exit.");
                if (CheckIfValidHTML(userInput) == true)
                {
                    Console.WriteLine("That's a valid HTML tag!");
                    isValidHTML = true;
                }
                else if (userInput[0] == 'e')
                {
                    isValidHTML = true;
                }
                else
                {
                    Console.WriteLine("Not a valid format.");

                }
            }


        }
        static bool CheckIfName(string input)
        {
            if (input.Length < 30)
                return Regex.IsMatch(input, @"^[A-Z]\w+[a-z]{5,30}");
            else
                return false;
        }

        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        static bool CheckIfEmail(string input)
        {
            if (input.Length > 5 && input.Length < 30)
                return Regex.IsMatch(input, @"^([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)");
            else
                return false;
        }
        static bool CheckIfPhoneNumber(string input)
        {
            return Regex.IsMatch(input, @"^([0-9]{1,3}[-]{1,1}[0-9]{0,3}[-]{1,1}[0-9]{1,4})$");
        }
        static bool CheckIfValidDate(string input)
        {
            return Regex.IsMatch(input, @"^(0?([0-9]|[12][0-9]|[3][01]){1}[/]{1}[0-9]{2}[/]{1}[0-9]{4})$");
        }
        static bool CheckIfValidHTML(string input)
        {
            return Regex.IsMatch(input, @"^([<]{1}[A-z]{1}[>]{1}[<]{1}[/]{1}[A-z]{1}[>])$");
        }
    }
}
