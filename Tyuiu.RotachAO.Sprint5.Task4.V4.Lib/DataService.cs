using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task4.V4.Lib;

public class DataService : ISprint5Task4V4
{
    public double LoadFromDataFile(string path)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string strX = File.ReadAllText(path);
        double x = double.Parse(strX);
        double res = Math.Round((0.25*x)/Math.Cos(x), 3);
        return res;
    }
} 
