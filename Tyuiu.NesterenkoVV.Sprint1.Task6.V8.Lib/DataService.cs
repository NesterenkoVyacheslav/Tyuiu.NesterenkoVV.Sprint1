using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NesterenkoVV.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string z = "";
            string[] words = value.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                string y = words[i];
                string q = y.Substring(1) + y[0];
                z += " " + q;
            }
            z = z.Trim();
            return z;
        }
    }
}
