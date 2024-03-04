namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(25);
            Console.WriteLine($"25 Fahrenheit is {celsius} degrees celsius");
            var fahrenheit = TempConverter.CelsiusToFahrenheit( celsius );
            Console.WriteLine($"It is {fahrenheit} degrees converted back to fahrenheit");
        }
    }
}
