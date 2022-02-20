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
        int r = 6371;
        double pi = 3.1415926535f;
        int aLenght = 10;
        int bLenght = 15;

        public void AssignAndWrite()
        {
            area = Math.Round(CountArea(), 2);
            volume = Math.Round(CountVolume(), 2);
            length = Math.Round(CountLength(), 2);
            Console.WriteLine($"Area: {area} \nVolume: {volume} \nLength: {length} \nSum: {area + volume + length} \nAverage: {(area + volume + length) / 3}");
        }

        public double CountArea()
        {
            area = 4 * pi * (r * r);
            return area;
        }

        public double CountVolume()
        {
            volume = 4f / 3f * pi * (r * r * r);
            return volume;
        }

        public double CountLength()
        {
            length = Math.Sqrt((aLenght*aLenght)+(bLenght*bLenght));
            return length;
        }
    }
}
