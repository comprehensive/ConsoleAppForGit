using System;
using ConsoleAppReloaded.Domain;

namespace ConsoleAppReloaded
{
    class Program
    {
        static void Main()
        {
            Feeder feeder = new Feeder();
            Console.WriteLine(feeder.Talk());
            Console.ReadLine();
        }
    }
}
