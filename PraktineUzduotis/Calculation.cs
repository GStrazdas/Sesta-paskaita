using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktineUzduotis
{
    internal class Calculation
    {
        public double hypotenuse;
        public void CalcHypotenuse()
        {
            var a = 10;
            var sqrA = a*a;
            var b = 15;
            var sqrB = b*b;
            var sqrC = sqrA + sqrB;
            var hypotenuse = Math.Sqrt(sqrC);
            hypotenuse = Math.Round(hypotenuse);
            Console.WriteLine($"*Hypotenuse: {hypotenuse};");
        }
    }
}
