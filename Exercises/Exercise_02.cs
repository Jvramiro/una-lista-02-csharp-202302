namespace Atividades;
public static class Exercise_02{

    public static void Exercise(){

        Console.WriteLine("This Exercise will calculate an amount plus a percentage of 10%\nFirst insert the Amount");
        float value = InputServices.ReadFloat();

        float result = value + ( value * 0.1f );
        Console.WriteLine($"The new value is {result}");

    }

}
