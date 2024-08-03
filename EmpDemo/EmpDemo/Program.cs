using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            
            Console.WriteLine("Enter Employee Name :");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Salary :");
            Int32 salary = Convert.ToInt32(Console.ReadLine());

            emp.SetName(name);
            emp.Salary = salary;

            emp.CalculateBonus();
            emp.CalaculateNetSalary();

            Tuple<String, int, float, float> result = emp.GetData();
            Console.WriteLine("Enter Employee Name :"+result.Item1);
            Console.WriteLine("Enter Salary :" + result.Item2);
            Console.WriteLine(" Bonus :" + result.Item3);
            Console.WriteLine("Net Salary :" + result.Item4);
            Console.ReadKey();
        }
    }
}
