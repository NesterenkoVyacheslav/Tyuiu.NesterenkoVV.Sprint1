using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NesterenkoVV.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double z = 32;
            int Q = Convert.ToInt32((temp - z) * (double)5/9);
            return Q;
        }
    }
}
