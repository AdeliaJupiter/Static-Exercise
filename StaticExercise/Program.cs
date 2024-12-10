namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double f = 32;
            double c = 0;
            Console.WriteLine(TempConverter.FahrenheitToCelcius(f));
            Console.WriteLine(TempConverter.CelciusToFahrenheit(c));
        }
    }
}
