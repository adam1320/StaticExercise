using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            var CTemp = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"68 F converts to {CTemp} C.");

            var FTemp = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"20 C converts to {FTemp} F.");
        }
    }
}
