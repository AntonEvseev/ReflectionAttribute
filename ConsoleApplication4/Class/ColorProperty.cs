using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RA
{
    public class ColorProperty
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
