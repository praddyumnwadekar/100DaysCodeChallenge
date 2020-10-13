
using System;

namespace DegreeConverter
{
    public class CelsiusDegreeConverter
    {
        private float celsius;

        public float Celsius
        {
            set
            {
                celsius = value;
            }
        }

        public void ConvertDegreeToKelvin()
        {
            Console.WriteLine("The conversion of celsius {0} is = {1}", celsius, (celsius + 273));
        }

        public void ConvertDegreeToFahrenheit()
        {
            Console.WriteLine("The conversion of celsius {0} is = {1}", celsius, (celsius * 9 / 5) + 32);
        }

    }
}
