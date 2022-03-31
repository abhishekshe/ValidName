using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class Pattern
    {
        public static string ValidName = "^[A-Z]{1}[a-z]{3,}";

        public bool ValidateName(string Name)
        {
            return Regex.IsMatch(Name, ValidName);
        }
    }
}
