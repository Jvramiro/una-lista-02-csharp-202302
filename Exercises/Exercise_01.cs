namespace Atividades;
public static class Exercise_01{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the average of two numbers");
        int quantity = 2;
        var numbers = new List<float>();
        for(int i = 0; i < quantity; i++){
            numbers.Add(InputServices.ReadFloat());
        }
        var result = MathServices.Average(numbers);
        Console.WriteLine($"The average is {result}");
    }

}
