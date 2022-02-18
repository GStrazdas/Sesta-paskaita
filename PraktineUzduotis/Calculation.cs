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
        public void CalculatEarthArea()
        {
            int radius = 6371;
            double constant = 3.14;
            earthArea = Math.Round((radius * radius) * (4 * constant), 2);
            Console.WriteLine($"eartArea: { earthArea}");
        }

        public double earthVolume;
        public double hypotenuse;
        public double ourSum;
        public double ourAverage;
    }
}
