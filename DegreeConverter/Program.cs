using System;

namespace DegreeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dc = new CelsiusDegreeConverter();

            Console.WriteLine("Enter the Degree Celsius");
            //int celsiusDegree = Convert.ToInt32(Console.ReadLine());
            dc.Celsius = 1;
            dc.ConvertDegreeToKelvin();
            dc.ConvertDegreeToFahrenheit();
        }
    }
}
