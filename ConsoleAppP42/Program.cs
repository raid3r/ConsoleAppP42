
// Структури



using ConsoleAppP42.Dim2;
using ConsoleAppP42.Dim3;


var p1 = new ConsoleAppP42.Dim2.Point(); // Виклик конструктора за замовчуванням

p1.Name = "A";
//p1.X = 10;
//p1.Y = 20;

p1.Display(); // Виведе: Point Coordinates: (10, 20)


var p2 = new ConsoleAppP42.Dim3.Point { Name = "B", X = 30, Y = 40, Z = 23 };
p2.Display(); // Виведе: Point Coordinates: (30, 40, 23)


// Класи

var rect = new Rectangle(10, 20, "MyRectangle");

Console.WriteLine($"Rectangle category: {Rectangle.Category}");

rect.DisplayInfo();


var rect2 = new Rectangle(15, 25, "AnotherRectangle");

Rectangle.Count++;

var rect3 = new Rectangle(name: "ThirdRectangle", height: 40, width: 30);

rect3.DisplayInfo();


var rect4 = new Rectangle(5, 10, "FourthRectangle");

//int width = rect4.GetWidth();
//int height = rect4.GetHeight();
//int width, height;
rect4.GetDimensions(out int width, out int height);

Console.WriteLine($"Width: {width}, Height: {height}");

float area = 0;
float perimeter = 0;

//Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");

rect4.AddCalculations(ref area, ref perimeter);

Console.WriteLine($"Area: {area}, Perimeter: {perimeter}");

rect4.Width = 10; // set

Console.WriteLine($"Updated Width: {rect4.Width}"); // get

//rect4.StartX = 10; // Error: cannot assign to 'StartX' because it is read-only
Console.WriteLine($"StartX: {rect4.StartX}"); // get

Console.WriteLine($"Area via property: {rect4.Area}");
Console.WriteLine($"Perimeter via property: {rect4.Perimeter}");

var rect5 = new Rectangle { 
    Height = 50, 
    Width = 60, 
};

Console.WriteLine($"Rect5 - Width: {rect5.Width}, Height: {rect5.Height}, Area: {rect5.Area}");


var rect6 = new Rectangle("New rect") {
    Height = 70,
    Width = 80,
    Depth = 5, // Нове поле в Rectangle
};

Console.WriteLine($"Rect6 - Width: {rect6.Width}, Height: {rect6.Height}, Area: {rect6.Area}");
Console.WriteLine($"Rect6 - Depth: {rect6.Depth}");


/*
 * Створіть клас "Місто". Необхідно зберігати у полях класу: назву міста, 
 * назву країни, кількість жителів у місті, телефонний код міста, назву районів міста. 
 * Реалізуйте методи класу для введення даних, виведення даних. 
 * Реалізуйте доступ до окремих полів через методи класу.
 * 
 * 
 */ 