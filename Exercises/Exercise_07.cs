namespace Atividades;
public static class Exercise_07{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the salary of a salesman according with the sales");
        Console.WriteLine("First insert the fixed salary");
        float salary = InputServices.ReadFloat();
        Console.WriteLine("Insert the amount value of sales in the month");
        float salesAmount = InputServices.ReadFloat();
        Console.WriteLine("Insert the comission percentage");
        float comission = InputServices.ReadFloat();

        float result = salary + ( salesAmount * ( comission/100 ) );

        Console.WriteLine($"The salesman salary will be {result.ToString("0,0")}");


    }
    
}
