using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class Pattern
    {
        public static string firstname = "^[A-Z][a-z]*[ ]?[a-z]+$";
        public static string lastname = "^[A-Z][a-z]*[ ]?[a-z]+$";
        public static string email = "^[a-zA-Z0-9]+([.#_+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string mobile = "^[0-9]{2}[ ][6-9][0-9]{9}$";
        public static string regex = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#?$&])(?=.*[A-Z])[a-zA-Z0-9!@#?$&]{8,}$";

        public bool Validatefirstname(string sample)
        {
            return Regex.IsMatch(sample, firstname);
        }
        public bool Validatelastname(string sample)
        {
            return Regex.IsMatch(sample, lastname);
        }
        public bool Validateemail(string sample)
        {
            return Regex.IsMatch(sample, email);
        }
        public bool ValidateMobileNumber(string sample)
        {
            return Regex.IsMatch(sample, mobile);
        }
        public bool ValidatePassword(string sample)
        {
            return Regex.IsMatch(sample, email);
        }
    }
}
