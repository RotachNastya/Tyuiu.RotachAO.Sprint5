using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task5.V8.Lib;

public class DataService : ISprint5Task5V8
{
        public double LoadFromDataFile(string path)
        {
            double min = 100000;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) < min)
                    {
                        min = Convert.ToDouble(line);
                    }

                }
            }
            return Math.Round(min, 3);
        }
    }
