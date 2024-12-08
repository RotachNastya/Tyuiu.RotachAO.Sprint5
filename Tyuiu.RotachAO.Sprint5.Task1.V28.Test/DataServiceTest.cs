using Tyuiu.RotachAO.Sprint5.Task1.V28.Lib; 
 
namespace Tyuiu.RotachAO.Sprint5.Task1.V28.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        string path = @"C:\Users\Linn\AppData\Local\Temp\OutPutFileTask1.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        Assert.AreEqual(true, fileExists);
    } 
} 
