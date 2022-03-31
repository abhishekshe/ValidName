using RegexValidation;
using System;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.ValidateEmail("abhis.adds@bl.co.in"));
        }


    }
}