using RegexValidation;
using System;

namespace Regex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.ValidateName("uhqwaaAA1223"));
        }


    }
}