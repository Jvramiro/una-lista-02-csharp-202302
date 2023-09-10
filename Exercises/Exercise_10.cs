namespace Atividades;
public static class Exercise_10{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the arithmetic, harmonic and geometric average");
        int quantity = 3;
        var numbers = new List<float>();
        for(int i = 0; i < quantity; i++){
            numbers.Add(InputServices.ReadFloat());
        }
        var averageArithmetic = MathServices.Average(numbers);
        Console.WriteLine($"The arithmetic average is {averageArithmetic.ToString("0,00")}");
        var averageHarmonic = MathServices.AverageHarmonic(numbers);
        Console.WriteLine($"The Harmonic average is {averageHarmonic.ToString("0,00")}");
        var averageGeometric = MathServices.AverageGeometric(numbers);
        Console.WriteLine($"The Geometric average is {averageGeometric.ToString("0,00")}");
    }
    
}
