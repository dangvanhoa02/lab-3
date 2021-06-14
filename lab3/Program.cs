using System;

namespace t2009a_lab
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Thien","Khang","Singer", 382, 38000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculateTheBonus(2));
        }
    }
}