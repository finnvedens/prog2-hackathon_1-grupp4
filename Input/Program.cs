using System;
using System.Collections.Generic;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Input i = new Input();

            Console.WriteLine(i.getKeyword("attack"));
        }
    }
}