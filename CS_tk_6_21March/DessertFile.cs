using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
namespace CS_tk_6_21March
{
    public class DessertFile
    {
       
        public void DessertWriter()
        {
            var fileName = @"D:\Files.txt";
            List<string> desserts = new List<string>();
            desserts.Add("BlacForest");
            desserts.Add("Chocolava");
           

            FileStream desserfile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter dessertStream = new StreamWriter(desserfile);
            foreach (string dessert in desserts)
            {
                dessertStream.Write(dessert + "\n");
            }

            dessertStream.Flush();
            dessertStream.Close();
            desserfile.Close();
        }

        public void DesserReader()
        {
            var fileName = @"D:\Files.txt";
            FileStream dessertReaderFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader DessertReaderStream = new StreamReader(dessertReaderFile);
            String outputData = DessertReaderStream.ReadToEnd();
            DessertReaderStream.Close();
            dessertReaderFile.Close();

            Console.WriteLine(outputData);
            FileInfo info = new FileInfo(fileName);
            Console.WriteLine(info.Length);
            Console.WriteLine(info.CreationTime);
            
        }
    }
    
}
