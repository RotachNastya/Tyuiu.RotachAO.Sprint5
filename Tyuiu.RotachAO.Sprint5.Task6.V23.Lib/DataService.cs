using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task6.V23.Lib;

public class DataService : ISprint5Task6V23
{
    public int LoadFromDataFile(string path)
    {
          string fileContent = File.ReadAllText(path);
        int count = 0;

        foreach (char c in fileContent)
        {
            if (c == '-')
            {
                count++;
            }
        }

        return count;
    }
} 
