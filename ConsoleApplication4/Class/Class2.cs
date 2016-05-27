using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication4
{
    public class Cat
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
}
