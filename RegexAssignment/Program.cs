using RegexAssignment;
using System;

namespace RegexAssignmnent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Regular Expression------\n");
            Console.WriteLine("1.Usecase one: Validating FirstName \n");
            Console.WriteLine("2.Usecase two: Validating LastName \n");
            Console.WriteLine("3.Usecase three: Validating Email \n");
            Console.WriteLine("4.Usecase four: Validating Mobile Number\n");
            Console.WriteLine("5.Usecase 5-9: Validating Password\n");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Choose the Nummber between 1-5");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            PatternMatching pattern = new PatternMatching();
            pattern.CheckPattern(userchoice);
        }
    }
}