using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupesDarbas1
{
    internal class Class1
    {
        double area;
        double volume;
        double length;

        public void AssignAndWrite()
        {
            area = Math.Round(CountArea(), 2);
            volume = Math.Round(CountVolume(), 2);
            length = Math.Round(CountLength(), 2);
            Console.WriteLine($"Area: {area} \nVolume: {volume} \nLength: {length} \nSum: {area + volume + length} \nAverage: {(area + volume + length) / 3}");
        }

        public double CountArea()
        {
            //kodas su return

        }

        public double CountVolume()
        {
            //kodas su return

        }

        public double CountLength()
        {
            //kodas su return
        }
    }
}
