using System;
using System.Text.RegularExpressions;


namespace RegexValidation
{
    public class Pattern
    {
        public static string ValidMobileNo = "^[91]+[ ][6-9]{1}[0-9]{9}";

        public bool ValidateMobileNo(string Mobile)
        {
            return Regex.IsMatch(Mobile, ValidMobileNo);
        }
    }
}
