using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task3.V10.Lib;

public class DataService : ISprint5Task3V10
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        int y = -6;
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
        {
            writer.Write(BitConverter.GetBytes((int)y));
        }
        return path;
    }
} 
