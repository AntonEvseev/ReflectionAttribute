using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RA
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorPropertyAttribute : System.Attribute
    {
        public ColorPropertyAttribute(ConsoleColor color)
        {
            Color = color;
        }
        public ConsoleColor Color { get; private set; }
    }
}
