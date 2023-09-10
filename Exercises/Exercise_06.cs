namespace Atividades;
public static class Exercise_06{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the logarithm");
        Console.WriteLine("First insert the number");
        float argument = InputServices.ReadFloat();
        Console.WriteLine("Insert the logarithm base");
        float baseValue = InputServices.ReadFloat();

        var result = Math.Log(argument, baseValue);
        
        Console.WriteLine($"The logarithm of {argument} in base {baseValue} is {result}");
    }
    
}
