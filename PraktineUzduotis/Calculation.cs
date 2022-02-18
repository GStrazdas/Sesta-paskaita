using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktineUzduotis
{
    internal class Calculation
    {
        public double earthArea;
        public double earthVolume;
        public double hypotenuse;
        public void CalcHypotenuse()
        {
            int a = 10;
            int b = 15;
            double hypotenuse = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine($"* Hypotenuse: {Math.Round(hypotenuse)};");
        }
        public double ourSum;
        public double ourAverage;
    }
}
