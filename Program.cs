using System;

namespace SampleApp
{
    
    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine("Hello World Updated!");
            Employee employee = new Employee {Id = 101,Name = "Hema", Salary = 95000.00};
            Console.WriteLine(employee);
        }
    }
}
