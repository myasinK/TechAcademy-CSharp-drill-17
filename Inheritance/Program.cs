using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string FirstName = "Unknown";
        public string LastName = "Unknown";
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    public class Employee : Person
    {
        public int Id = 0;
        public new void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
        }
    }
}
