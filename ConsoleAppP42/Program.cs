
using ConsoleAppP42.Garbadge;
using System.IO;
using System.Text;

/*
 * Життєвий цикл будь-якого об'єкта можна представити так:

Виділення пам'яті для типу;

Ініціалізація виділеної пам'яті (встановлення об'єкта в початкове значення — виклик конструктора);

Використання об'єкта в програмі;

Руйнування стану об'єкта;

Звільнення зайнятої пам'яті.
 * 
 * 
 */

//void Test()
//{
//    List<Foo> foos = new List<Foo>();

//    for (int i = 0; i < 1000; i++)
//    {
//        foos.Add(new Foo(i));
//    }

//    foos.Clear();

//}


///*
// * Покоління сміття
// * 0 покоління — це об'єкти, які щойно були створені. Вони займають найменше місце в купі і збираються найчастіше.
// * 1 покоління — це об'єкти, які пережили принаймні одну збірку сміття.
// * 2 покоління — це об'єкти, які пережили кілька збірок сміття і зазвичай живуть довше.
// */



////Test();
//void Test2()
//{
//    int a = 10;
//    int b = 20;

//    using var foo = new Foo(a + b);
//    using var foo2 = new Foo(a + b);

//    foo.Add(100);

//    foo2.Add(1000);
//    Console.WriteLine($"Foo2 value inside using: {foo2.Value}");


//    foo.Add(200);
//    Console.WriteLine($"Foo value inside using: {foo.Value}");


//    //using (var foo = new Foo(a + b))
//    //{

//    //    using (var foo2 = new Foo(a + b))
//    //    {
//    //        foo.Add(100);
//    //        foo.Add(200);
//    //        Console.WriteLine($"Foo value inside using: {foo.Value}");
//    //        foo2.Add(300);
//    //        Console.WriteLine($"Foo2 value inside using: {foo2.Value}");
//    //    }
//    //}
//}


//Test2();

//GC.Collect();

//Console.ReadLine();


//Console.WriteLine("Before GC");

//Console.WriteLine("Generation 0 count:" + GC.CollectionCount(0));
//Console.WriteLine("Generation 1 count:" + GC.CollectionCount(1));
//Console.WriteLine("Generation 2 count:" + GC.CollectionCount(2));



//Console.ReadLine();
//GC.Collect();
//Console.WriteLine("After GC");

//Console.WriteLine("Generation 0 count:" + GC.CollectionCount(0));
//Console.WriteLine("Generation 1 count:" + GC.CollectionCount(1));
//Console.WriteLine("Generation 2 count:" + GC.CollectionCount(2));

//var mi = GC.GetGCMemoryInfo();
//Console.WriteLine($"Memory Load: {mi.MemoryLoadBytes / 1024 / 1024} MB");



//Console.ReadLine();

//// Примусове викликання збирача сміття

////GC.WaitForPendingFinalizers();
//Console.WriteLine("End of Main");


// Потоки

using MemoryStream ms = new MemoryStream();
using FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
using BufferedStream bs = new BufferedStream(fs);

string text = "Hello, World!";
ms.Write(Encoding.UTF8.GetBytes(text));
ms.Seek(0, SeekOrigin.Begin);
ms.CopyTo(bs);

// Reading from streams
// Для читання з потоків використовуються класи TextReader, StreamReader, BinaryReader та інші.

using StringReader strReader = new StringReader(text);
using TextReader reader = new StreamReader(ms);
using BinaryReader binReader = new BinaryReader(ms);

reader.ReadLine();
reader.ReadToEnd();

// Writing to streams
// Для запису в потоки використовуються класи TextWriter, StreamWriter, BinaryWriter та інші.

using StringWriter strWriter = new StringWriter();
using TextWriter writer = new StreamWriter(ms);
using BinaryWriter binWriter = new BinaryWriter(ms);

binWriter.Write(12345);
binWriter.Write(67.89);



// Прочититати з файлу
//using StreamReader fileReader = new StreamReader("test.txt");
//string fileContent = fileReader.ReadToEnd();

//Console.WriteLine(fileContent);

//var content = File.ReadAllText("test.txt");
File.WriteAllText("test.txt", "This is a test file.");


//using FileStream fileStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
//using TextReader fileReader = new StreamReader(fileStream);
//string fileContent = fileReader.ReadToEnd();

using FileStream fileStream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
using FileStream fileStream2 = new FileStream("test_copy.txt", FileMode.Create, FileAccess.Write);
fileStream.CopyTo(fileStream2);



//var buffer = new byte[fileStream.Length];
//fileStream.Read(buffer, 0, buffer.Length);
//string fileContent = Encoding.UTF8.GetString(buffer);








