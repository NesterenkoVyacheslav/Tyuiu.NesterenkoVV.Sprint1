using Tyuiu.NesterenkoVV.Sprint1.Task6.V8.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Нестеренко В. В. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПБ-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя текст,           *");
            Console.WriteLine("* перенеся их первую букву слов в конец                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            string x;
            Console.WriteLine("Введите предложение");
            x = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.MoveLetterToEnd(x);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
