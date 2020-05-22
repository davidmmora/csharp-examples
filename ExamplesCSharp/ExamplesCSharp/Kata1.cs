using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExamplesCSharp
{
    public class Kata1
    {
        //Reverse string 
        public string Solution(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    }
}
