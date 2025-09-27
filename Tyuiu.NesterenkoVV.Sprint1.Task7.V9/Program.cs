using Tyuiu.NesterenkoVV.Sprint1.Task7.V9.Lib;
namespace Tyuiu.NesterenkoVV.Sprint1.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Нестеренко В. В. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПБ-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные значения*");
            Console.WriteLine("* и вычесляет выражение по формале                                         ");
            Console.WriteLine("*        2       2           2                                            *");
            Console.WriteLine("*       y  - cosx  + 12xy - 3x                                            *");
            Console.WriteLine("*    2                                                                    *");
            Console.WriteLine("* z=e  - ---------------------                                            *");
            Console.WriteLine("*             3                                                           *");
            Console.WriteLine("*        cos(x + 3) + 18y - 1                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение X");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x, y);
            Console.WriteLine("z = "+res);
            Console.ReadLine();
        }
    }
}
