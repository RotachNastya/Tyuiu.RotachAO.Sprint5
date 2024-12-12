using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task3.V10.Lib;

public class DataService : ISprint5Task3V10
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        double y = -x*x*x + 4*x*x -(3/2.0)*x;
        y = Math.Round(y, 3);
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
        {
            writer.Write(BitConverter.GetBytes((int)y));
        }
        return path;
    }
} 
