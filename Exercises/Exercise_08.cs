namespace Atividades;
public static class Exercise_08{

    public static void Exercise(){
        Console.WriteLine("This Exercise will calculate the amount of cars and motorcycles using the total of wheels");
        Console.WriteLine("First insert the total of Vehicles");
        int vehiclesQuantity = InputServices.ReadInt();
        Console.WriteLine("Insert the total os Wheels");
        int wheelsQuantity = InputServices.ReadInt(ValueProperties.even);

        int maxCars = wheelsQuantity / 4;
        int motorcyclesQuantity = Math.Min(vehiclesQuantity, maxCars);
        int carsQuantity = vehiclesQuantity - motorcyclesQuantity;

        Console.WriteLine($"A possible scenery {carsQuantity} cars and {motorcyclesQuantity} motorcycles");
    }
    
}
