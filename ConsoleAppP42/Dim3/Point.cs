using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Dim3
{
    struct Point
    {
        public int X;
        public int Y;
        public int Z;

        public string Name;

        // Метод для відображення координат
        public void Display()
        {
            Console.WriteLine($"Point Coordinates: {Name} ({X}, {Y}, {Z})");
        }
    }
}
