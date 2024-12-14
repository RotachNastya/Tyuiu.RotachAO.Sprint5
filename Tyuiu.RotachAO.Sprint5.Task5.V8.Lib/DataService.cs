using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5; 
 
namespace Tyuiu.RotachAO.Sprint5.Task5.V8.Lib;

public class DataService : ISprint5Task5V8
{
        public double LoadFromDataFile(string path)
        {
        string fileContent = File.ReadAllText(path);
        var values = fileContent
            .Split(new[] { ' ', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(val =>
            {
                if (double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
                {
                    return Math.Round(doubleValue, 3);
                }
                return (double?)null;
            })
            .Where(val => val.HasValue)
            .Select(val => val.Value)
            .ToArray();
        var minInteger = values.Where(val => val == Math.Truncate(val)).Min();
        return minInteger;
    }
    }
    
