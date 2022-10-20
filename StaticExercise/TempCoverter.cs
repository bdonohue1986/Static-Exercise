using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempCoverter 
    {
      public static double FahrenheitToCelsius(double fahrenheit)
        {
            var temp = (fahrenheit - 32) * .55;
            return temp;
        }
     
      public static double CelsiusToFahrenheit(double celsius) 
        {
            var temp = (celsius * 1.8) + 32;

            return temp;
        }

      
        

    }
}
