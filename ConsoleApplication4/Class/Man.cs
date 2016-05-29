using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RA
{
    public class Man
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
}
