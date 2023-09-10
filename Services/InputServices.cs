namespace Atividades;

public enum ValueProperties{none, even, odd}
public static class InputServices{

    public static string message = "Insert a number: ";
    public static string warning = "Insert a valid number: ";
    public static int ReadInt(ValueProperties properties = ValueProperties.none){
        Console.Write(message);
        var input = (int)CheckInput(typeof(int), properties);
        return input;
    }
    public static float ReadFloat(ValueProperties properties = ValueProperties.none){
        Console.Write(message);
        var input = (float)CheckInput(typeof(float), properties);
        return input;
    }

    private static object CheckInput(Type type, ValueProperties properties = ValueProperties.none){
        while(true){
            try{
                var check = Console.ReadLine()?.Replace('.',',');
                var toReturn = Convert.ChangeType(check, type);
                if(toReturn == null){
                    throw new Exception("Erro while converting Read Line to type");
                }

                //Ever or Odd Region
                if(properties != ValueProperties.none){
                    int checkProperties = Convert.ToInt32(toReturn);
                    if(properties == ValueProperties.odd && checkProperties % 2 == 0){
                        Console.WriteLine("Please insert a Even number");
                        throw new Exception("Erro while converting Read Line to type");
                    }
                    else if(properties == ValueProperties.even && checkProperties % 2 != 0){
                        Console.WriteLine("Please insert a Odd number");
                        throw new Exception("Erro while converting Read Line to type");
                    }
                }

                return toReturn;
            }
            catch{
                Console.Write(warning);
            }
        }
    }

}
