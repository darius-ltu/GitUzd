using System;

namespace GrupesDarbas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 tasks = new Class1();
            tasks.AssignAndWrite();
            var sum = tasks.CountAreaWolume();
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
