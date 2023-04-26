using System;
using System.Collections.Generic;

namespace Convert_Temperature.Classes
{
    internal class Convert_Class
    {
        public static int numbGradus { get; set; }

        public Convert_Class(int _numbGradus)
        {
            numbGradus = _numbGradus;
        }

        public List<string> Convert_Temperature()
        {
            var list = new List<string>();
            
            var sumFahrenheit = numbGradus * 1.8 + 32;
            var sumCelsius = (numbGradus - 32) / 1.8;

            list.Add($" {numbGradus}C = {sumFahrenheit} F");
            list.Add($" {numbGradus}F = {sumCelsius} C");

            return list;
        }
    }
}
