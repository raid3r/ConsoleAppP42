using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Dim2;

// internal
// public
public partial class Rectangle
{
    // Конструктор класу Rectangle
    public Rectangle()
    {

    }

    public Rectangle(string name)
    {
        this.name = name;
    }
    public Rectangle(int width, int height, string name)
    {
        this.Width = width;
        this.Height = height;
        this.name = name;
        StartX = 10;
    }

    private readonly string name;

    static Rectangle()
    {
        Count = 0;
    }


    public static int Count = 0;

    public static void DisplayCount()
    {
        Console.WriteLine(Category);
        Console.WriteLine($"Total Rectangles Created: {Count}");
    }

    #region Properties

    /*
        private int width;
        public int GetWidth()
        {
            return width;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        } 
     */

    /*
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
     */

    // Auto-implemented property
    public int Width { get; set; }

    public int Height { get; set; }

    public int Depth;

    // Публіне на читання, приватне на запис
    public int StartX { get; private set; }

    // Read-only property
    public float Area
    {
        get { return (float)Width * Height; }
    }

    public float Perimeter
    {
        get { return 2 * ((float)Width + Height); }
    }

    #endregion


    public const string Category = "Geometric Shape";

    public void SetName(string rectangleName)
    {
        //this.name = name;
        //throw new InvalidOperationException("Name is read-only and cannot be changed.");
    }


    

    public float CalculateArea()
    {
        return (float)Width * Height;
    }

    public float CalculatePerimeter()
    {
        return 2 * ((float)Width + Height);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Rectangle: {Category}: Width = {Width}, Height = {Height}, Area = {CalculateArea()}");
    }

    public void DisplayInfo(bool areaOnly)
    {
        Console.WriteLine("Area=" + CalculateArea());
    }

    // ref out параметри
    public void GetDimensions(out int width, out int height)
    {
        width = this.Width;
        height = this.Height;
    }


    public void GetMinAndMax(out int min, out int max)
    {
        var arr = new int[] { 10, 3, 5, 2, 1 };
        min = arr[0];
        max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
    }


    public void AddCalculations(ref float perimeter, ref float area)
    {
        perimeter += CalculatePerimeter();
        area += CalculateArea();
    }

}




