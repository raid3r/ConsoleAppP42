using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Garbadge;

public class Foo: IDisposable
{
    public int Value { get; set; }

    public Foo(int value)
    {
        Value = value;
        Console.WriteLine($"Foo created with value: {Value}");
    }

    public void Add(int x)
    {
        Value += x;
    }

    private bool  disposed = false;

    public void Dispose()
    {
        if (disposed)
            return;

        // Очистка ресурсів
        Console.WriteLine($"Foo with value {Value} is being disposed.");

        disposed = true;
        
        // Запобігання виклику фіналізатора
        GC.SuppressFinalize(this);
    }

    ~Foo()
    {
        Dispose();
        Console.WriteLine($"Foo with value {Value} is being finalized.");
    }

}


public class Bar
{
    public int Value { get; set; }

    public Bar(int value)
    {
        Value = value;
        Console.WriteLine($"Bar created with value: {Value}");
    }

    public void Add(int x)
    {
        Value += x;
    }

    private bool disposed = false;

    public void Dispose()
    {
        if (disposed)
            return;

        // Очистка ресурсів
        Console.WriteLine($"Bar with value {Value} is being disposed.");

        disposed = true;

        // Запобігання виклику фіналізатора
        GC.SuppressFinalize(this);
    }

    ~Bar()
    {
        Dispose();
        Console.WriteLine($"Bar with value {Value} is being finalized.");
    }

}
