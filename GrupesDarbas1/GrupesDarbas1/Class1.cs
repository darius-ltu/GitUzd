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
        int aLenght = 10;
        int bLenght = 15;

        public void AssignAndWrite()
        {
            area = Math.Round(CountArea(r), 2);
            volume = Math.Round(CountVolume(r), 2);
            length = Math.Round(CountLength(aLenght, bLenght), 2);
            Console.WriteLine($"Area: {area} \nVolume: {volume} \nLength: {length} \nSum: {area + volume + length} \nAverage: {(area + volume + length) / 3}");
        }

        public double CountArea(double a)
        {
            return Math.Pow(a, 2) * 4 * Math.PI;
        }

        public double CountVolume(double vol)
        {
            return Math.Pow(vol, 3) * 4 / 3 * Math.PI;

        }

        public double CountLength(int a, int b)
        {
            return Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
