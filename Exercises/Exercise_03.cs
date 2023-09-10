namespace Atividades;
public static class Exercise_03{

    public static void Exercise(){

        Console.WriteLine("This Exercise will convert a Temperature value from Fahrenheit to Celsius");
        float value = InputServices.ReadFloat();

        float result = (value - 32) / 1.8f;
        Console.WriteLine($"The temperature of {value} ºF is equivalent a {result.ToString("0.0")} ºC");

    }
    
}
