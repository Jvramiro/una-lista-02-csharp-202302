using System.Collections.Generic;
using System.Linq;
namespace Atividades;
public static class MathServices{

    public static float Average(List<float> values){
        float sum = values.Sum();
        float average = sum / values.Count();
        return average;
    }
    public static float AverageHarmonic(List<float> values){
        float sum = values.Sum(v => 1f/v);
        float average = values.Count() / sum;
        return average;
    }
    public static float AverageGeometric(List<float> values){
        float sum = values.Aggregate((amount, value) => amount * value);
        var average = Math.Pow(sum,1f/3f);
        return (float)average;
    }

}
