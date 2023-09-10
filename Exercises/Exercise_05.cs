namespace Atividades;
public static class Exercise_05{

    public static void Exercise(){

        float maxSalaryToBenefit = 1212.64f;

        Console.WriteLine("This Exercise will calculate an employee's salary plus family benefit\nAccording Brazilian criteria");
        Console.WriteLine("First insert the Workload (Hours of work)");
        int workload = InputServices.ReadInt();
        Console.WriteLine("Insert the hourly payment");
        float hourlyPayment = InputServices.ReadFloat();
        Console.WriteLine("Insert benefit amount quota");
        float benefit = InputServices.ReadFloat();
        Console.WriteLine("Insert the the number of children under the age of 14 and invalid children");
        int childrenQuantity = InputServices.ReadInt();

        float salary = workload * hourlyPayment;
        float totalBenefit = salary > maxSalaryToBenefit ? 0 : benefit * childrenQuantity;

        float result = salary + totalBenefit;

        Console.WriteLine($"The employee's salary will be {result}");
    }
    
}
