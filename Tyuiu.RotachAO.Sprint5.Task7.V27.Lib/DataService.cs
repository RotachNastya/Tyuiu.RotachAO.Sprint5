using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task7.V27.Lib;

public class DataService : ISprint5Task7V27
{
    public string LoadDataAndSave(string path)
    {
        // Чтение содержимого файла
        string fileContent = File.ReadAllText(path);

        // Удаление лишних пробелов
        string updatedContent = Regex.Replace(fileContent, @"\s{2,}", " ");

        // Сохранение изменений обратно в файл
        File.WriteAllText(path, updatedContent);

        // Возвращение изменённого содержимого
        return updatedContent;
    }
}
} 
