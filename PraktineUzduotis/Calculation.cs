using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktineUzduotis
{
    internal class Calculation
    {
        private double earthArea = 0;
        private double earthVolume = 0;
        private double hypotenuse = 0;
        private void EarthVolume()
        {
            const double earthRadius = 6371;
            earthVolume = Math.PI * Math.Pow(earthRadius, 3) * 4 / 3;
        }
        public void Results()
        {
            EarthVolume();
            double sum = earthArea + earthVolume + hypotenuse;
            double avg = sum / 3;
            Console.WriteLine("*********************************");
            Console.WriteLine("* Viso kintamųjų: 3");
            Console.WriteLine($"* earthArea: {earthArea}");
            Console.WriteLine($"* earthVolume: {earthVolume}");
            Console.WriteLine($"* hypotenuse: {hypotenuse}");
            Console.WriteLine($"* Suma: {sum}");
            Console.WriteLine($"* Vidurkis: {avg}");
            Console.WriteLine("*********************************");
        }
    }
}
