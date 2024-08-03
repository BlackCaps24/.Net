using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.Write("Enter the Name: ");
         //   String name = Console.ReadLine();

          //  Console.Write("Enter the City: ");
          //  String city = Console.ReadLine();

          //  Console.Write("Enter the Age: ");
           // Int32 age =Convert.ToInt32( Console.ReadLine());

           
          //  Console.WriteLine(string.Format("Name :{0}\nCity :{1}\nAge :{2}",name,city,age));
           


            Console.Write("enter the n1 :");
            Int32 n1 = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("enter the n2 :");
            Int32 n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + n2);

            Console.ReadKey();
        }
    }
}