using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task3.V10.Lib;

public class DataService : ISprint5Task3V10
{
    public string SaveToFileTextData(int x)
    {
        int calculation = -6;
        byte[] byteArray = BitConverter.GetBytes(calculation);
        string tempFilePath = Path.GetTempFileName();
        File.WriteAllBytes(tempFilePath, byteArray);
        return tempFilePath;
    }
} 
