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
    class Man
    {
        public string Name { get; set; }
        private int Age;
        [ColorProperty(ConsoleColor.Blue)]
        public string Eyes { get; set; }
        public Man(string name, int age, string color)
      {
         Name = name;
         Age = age;
         Eyes = color;
      }
    }
    class Cat
    {
        [ColorProperty(ConsoleColor.Yellow)]
        public string Name { get; set; }
        [ColorProperty(ConsoleColor.Red)]
        public string Color { get; set; }
        private int Age;
        public Cat(string name, string color, int age)
      {
         Name = name;
         Color = color;
         Age = age;
      }
    }
    [AttributeUsage(AttributeTargets.Property)]
    class ColorPropertyAttribute : System.Attribute
    {
        public ColorPropertyAttribute(ConsoleColor color)
        {
            Color = color;
        }
        public ConsoleColor Color { get; private set; }
    }
    class ColorProperty
    {
        public static void ColorPrint(object obj)
        {
            PropertyInfo[] props = obj.GetType().GetProperties();
            ConsoleColor oldColor = Console.ForegroundColor;
            foreach (var pinfo in props)
            {
                var colorAttr = pinfo.GetCustomAttribute<ColorPropertyAttribute>();
                if (colorAttr != null)
                {
                    Console.ForegroundColor = colorAttr.Color;
                }
                    object propValue = pinfo.GetValue(obj);
                    Console.WriteLine(propValue);
                if (colorAttr != null)
                { 
                    Console.ForegroundColor = oldColor;
                }
            }
        }
    }
}
