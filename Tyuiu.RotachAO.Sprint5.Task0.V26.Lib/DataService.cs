using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RotachAO.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = Math.Round((0.7*Math.Pow(x, 3)) + (1.52*x*x), 3);
            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
