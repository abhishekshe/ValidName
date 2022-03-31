using RegexValidation;
using System;

namespace Regex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.ValidatePassword("Agvsdv"));
        }


    }
}