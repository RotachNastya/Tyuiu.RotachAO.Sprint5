using Tyuiu.RotachAO.Sprint5.Task5.V8.Lib; 
 
namespace Tyuiu.RotachAO.Sprint5.Task5.V8; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Ротач. А. О. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #5                                                            *"); 
        Console.WriteLine("* Тема:                                                                *"); 
        Console.WriteLine("* Задание #5                                                           *"); 
        Console.WriteLine("* Вариант #8                                                          *"); 
        Console.WriteLine("* Выполнил: Ротач Анастасия Олеговна  | ИИПб-24-1                                       *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *"); 
        Console.WriteLine("*                                                                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();
    } 
} 
