using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task7.V27.Lib;

public class DataService : ISprint5Task7V27
{
    public string LoadDataAndSave(string path)
    {
        string fileContent = File.ReadAllText(path);
        string updatedContent = fileContent.Replace(" ", "");
        File.WriteAllText(path, updatedContent);
        return updatedContent;
    }
}

