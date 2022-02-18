using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktineUzduotis
{
    internal class Calculation
    {
        public double earthArea = 0;
        public double earthVolume = 0;
        public double hypotenuse = 0;
        public void CalcHypotenuse()
        {
            int a = 10;
            int b = 15;
            double hypotenuse = Math.Sqrt((a * a) + (b * b));
            hypotenuse = Math.Round(hypotenuse);
            Console.WriteLine($"* Hypotenuse: {hypotenuse};");
        }
        //public double ourSum = 0;
        //public double ourAverage = 0;
        public void Results()
        {
            double ourSum = earthArea + earthVolume + hypotenuse;
            Console.WriteLine($"* Sum: {ourSum}");
            double ourAverage = Math.Round(ourSum / 3);
            Console.WriteLine($"* Average: {ourAverage}");
            Console.WriteLine("***************************");

        }
    }
}
