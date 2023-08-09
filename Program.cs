using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace day21assg24
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 1,
                FullName = "Radhe",
                LastName = "Shyam",
                Salary = 90000
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D:\\Assignments\\Assignment24\\Employees.bin", FileMode.Create))
            {
                formatter.Serialize(fs, employee);
            }
            Console.WriteLine("Binary serialization done");

            //Reading the binary  file
            Console.WriteLine("*******Deserialized Data**********");
            using (FileStream fs1 = new FileStream("D:\\Assignments\\Assignment24\\Employees.bin", FileMode.Open))
            {
                Employee employee1 = (Employee)formatter.Deserialize(fs1);
                Console.WriteLine("Employee ID:" + employee1.Id);
                Console.WriteLine("Employee First Name:" + employee1.FullName);
                Console.WriteLine("Employee Last Name:" + employee1.LastName);
                Console.WriteLine("Employee Salary:" + employee1.Salary);
            }
            Console.WriteLine("\n");
            Console.WriteLine("_______________________________________________________________________");

            //XML serialization

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter textWriter = new StreamWriter("D:\\Assignments\\Assignment24\\Employees.Xml"))
            {
                serializer.Serialize(textWriter, employee);

            }
            Console.WriteLine("XML Serialization done");

            //xml deSerializer
            Console.WriteLine("*******Deserialized Data**********");
            using (TextReader textReader = new StreamReader("D:\\Assignments\\Assignment24\\Employees.Xml"))
            {
                Employee emp = (Employee)serializer.Deserialize(textReader);
                Console.WriteLine("Employee ID:" + emp.Id);
                Console.WriteLine("Employee First Name:" + emp.FullName);
                Console.WriteLine("Employee Last Name:" + emp.LastName);
                Console.WriteLine("Employee Salary:" + emp.Salary);
            }


            Console.ReadKey();
        }
    }
}
