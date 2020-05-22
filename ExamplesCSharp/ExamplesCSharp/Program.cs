using System;

namespace ExamplesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSharp Examples!");

            Kata1 kata1 = new Kata1();

            var outtext = kata1.Solution("tcejorp");

            Console.WriteLine(outtext);

            Kata2 kata2 = new Kata2();

            string number = kata2.NumberToString(1);

            Console.WriteLine(number);
        }
    }
}
