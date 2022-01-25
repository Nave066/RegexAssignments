using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    class PatternMatching
    {
        public void CheckPattern(int choice)
        {
            Pattern pattern = new Pattern();
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Your First Name:");
                        if (pattern.Validatefirstname(Console.ReadLine()))
                        {
                            Console.WriteLine("First Name is Valid");
                        }
                        else
                        {
                            Console.WriteLine("First Name is Invalid");
                        }
                        Console.ReadKey();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter Your Last Name:");
                        if (pattern.Validatelastname(Console.ReadLine()))
                        {
                            Console.WriteLine("Last Name is Valid");
                        }
                        else
                        {
                            Console.WriteLine("Last Name is Invalid");
                        }
                        Console.ReadKey();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Enter Your  Email id:");
                        if (pattern.Validateemail(Console.ReadLine()))
                        {
                            Console.WriteLine("Email is Valid");
                        }
                        else
                        {
                            Console.WriteLine("Email is Invalid");
                        }
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter Your Mobile Number:");
                        if (pattern.ValidateMobileNumber(Console.ReadLine()))
                        {
                            Console.WriteLine("Mobile Number is Valid");
                        }
                        else
                        {
                            Console.WriteLine("Mobile Number is Invalid");
                        }
                        Console.ReadKey();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter Your Password:");
                        if (pattern.ValidatePassword(Console.ReadLine()))
                        {
                            Console.WriteLine("Password is Valid");
                        }
                        else
                        {
                            Console.WriteLine("Password is Invalid");
                        }
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please Enter the Valid input");
                        break;
                    }
            }
           
        }
    }
}
