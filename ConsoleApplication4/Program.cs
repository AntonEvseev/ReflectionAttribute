using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Man man = new Man("Anton", 30, "Blue");
            Cat cat = new Cat("Мяу", "White", 5);
            Console.WriteLine("Свойства объекта " + man.GetType() + ":");
            ColorProperty.ColorPrint(man);
            Console.WriteLine("Свойства объекта " + cat.GetType() + ":");
            ColorProperty.ColorPrint(cat);
        }
    }
}
