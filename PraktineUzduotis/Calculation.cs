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
            double constant = Math.PI;
            earthArea = Math.Round((radius * radius) * (4 * constant), 2);
            Console.WriteLine($"eartArea: { earthArea}");
        }
        public double earthVolume;
        public double hypotenuse;
        public void CalcHypotenuse()
        {
            int a = 10;
            int b = 15;
            double hypotenuse = Math.Sqrt((a * a) + (b * b));
            hypotenuse = Math.Round(hypotenuse);
         }
        private void EarthVolume()
        {
            /*Skaiciavimas*/
            const double earthRadius = 6371;
            earthVolume = Math.Round(Math.PI * Math.Pow(earthRadius, 3) * 4 / 3, 0);
        }
        public void Results()
        {
            CalculatEarthArea();
            EarthVolume();
            CalcHypotenuse();
            double sum = earthArea + earthVolume + hypotenuse;
            double avg = Math.Round(sum / 3, 2);
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
