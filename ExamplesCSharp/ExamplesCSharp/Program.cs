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
        }
    }
}
