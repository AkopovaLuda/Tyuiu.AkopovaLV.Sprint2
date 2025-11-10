using Tyuiu.AkopovaLV.Sprint2.Task4.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема:  Оператор if – полная и короткая фоpма записи                     *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
        Console.WriteLine("* использованнем тернарного оператора, где пользователь вводит значение   *");
        Console.WriteLine("* переменных ху с клавиатуры, если х с у, то z = ( x + 3 ) / y иначе      *");
        Console.WriteLine("* ( x + 1 ) / ( x - 2 )                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите x:                                                                *");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:                                                                *");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double z = ds.Calculate(x,y);
        Console.WriteLine(z);
    }
}