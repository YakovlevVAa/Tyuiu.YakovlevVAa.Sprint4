using Tyuiu.YakovlevVAa.Sprint4.Task6.V4.Lib;
namespace Tyuiu.YakovlevVAa.Sprint4.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Яковлев В. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Москва, Санкт Петербург,                   *");
            Console.WriteLine("* Новосибирск, Екатеринбург, Нижний Новгород, Казахстан,                  *");
            Console.WriteLine("* Самара], используя класс Array, выведите элементы массива,              *");
            Console.WriteLine("* которых меньше 7 символов.                                              *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var city = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= city.Length - 1; i++)
            {
                Console.WriteLine(city[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(city);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
