using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class Pattern
    {
        public static string ValidPassword = "(?=.*[0-9A-Za-z])";

        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, ValidPassword);
        }
    }
}
