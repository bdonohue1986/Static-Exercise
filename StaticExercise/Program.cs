namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempCoverter.CelsiusToFahrenheit(34);
            var farenhiet = TempCoverter.FahrenheitToCelsius(74);

            Console.WriteLine($"After conversions the temp you gave for Farenheit was converted to { farenhiet} Celsius and the number u provided for Celsius was converted to { celsius} Farenheit.");

           

        }
    }
}
