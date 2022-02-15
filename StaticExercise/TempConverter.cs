using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp)
        {
            double FToC = (temp -  32) / 1.8;
            return FToC;
        }
        public static double CelsiusToFahrenheit(double temp)
        {
            double CToF = (temp * 9) / 5 + 32;
            return CToF;
        }
    }
}
