using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class Pattern
    {
        public static string ValidEmail = "^[a-z]+[.]+[a-z]+[@][bl]+[.][co]+[.][in]";

        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, ValidEmail);
        }
    }
}
