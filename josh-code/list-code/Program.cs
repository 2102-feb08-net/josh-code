using System;
using System.Collections.Generic;

namespace ListsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Josh" , "Anna" , "Felipe"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            Console.WriteLine();
            names.Add("Miranda");
            names.Add("Bill");
            names.Remove("Anna");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            Console.WriteLine($"My name is {names[0]}!");
            Console.WriteLine($"I have added {names[2]} and {names[3]} to the list!");
            Console.WriteLine($"The list has {names.Count} people on it.");

        }
    }
}
