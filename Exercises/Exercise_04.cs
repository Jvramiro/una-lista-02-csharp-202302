namespace Atividades;
public static class Exercise_04{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the compound interest of a financial application");
        Console.WriteLine("First insert the capital");
        float capital = InputServices.ReadFloat();
        Console.WriteLine("Insert the period in months");
        int period = InputServices.ReadInt();
        Console.WriteLine("Insert the interest rate");
        int interest = InputServices.ReadInt();

        var result = capital * Math.Pow(1 + interest, period);

        Console.WriteLine($"The final amount is {result.ToString("0,0")}");
    }
    
}
