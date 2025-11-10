using Tyuiu.AkopovaLV.Sprint2.Task4.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        double y = 0;
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:  Оператор if – полная и короткая форма записи                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение       *");
        Console.WriteLine("* до трех знаков после запятой;                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите x:                                                                *");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.Calculate(x, y);
        Console.WriteLine(res);
    }
}