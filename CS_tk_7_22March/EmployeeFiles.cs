using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CS_tk_7_22March
{
    public class EmployeeFile
    {
        public void WriteToBinaryFile(Employee Emp, bool append = false)
        {
            var filePath = @"D:\Files\fileread.txt";

            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, Emp);
            }
        }

        public void Deserialize()
        {
            var filename = @"D:\Files\fileread.txt";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Open(filename, FileMode.Open);

            object obj = formatter.Deserialize(fs);
            Employee emps = (Employee)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();

            Console.WriteLine("\n" + emps.Name + "\n" + emps.Gender + "\n" + emps.Age + "\n" + emps.Id);

        }
    }
}
