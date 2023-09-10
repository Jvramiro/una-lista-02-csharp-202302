namespace Atividades;
public static class Exercise_09{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the Time according the Seconds");
        Console.WriteLine("Insert the total os seconds");
        int seconds = InputServices.ReadInt();

        TimeSpan time = TimeSpan.FromSeconds(seconds);

        Console.WriteLine($"Converting {seconds} result in {time.ToString(@"hh\:mm\:ss")}");
    }
    
}
