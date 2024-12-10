using System;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius (double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double CelciusToFahrenheit (double celcius)
        {
            return (celcius * 9) / 5 + 32;
        }
    }
}
