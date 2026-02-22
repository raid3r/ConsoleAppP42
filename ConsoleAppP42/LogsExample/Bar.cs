using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.LogsExample;

public class Bar
{
    public void DoSomething()
    {
        Log.Information($"Метод DoSomething був викликаний о {DateTime.Now}");
    }

    public void Foo() {
        
        Log.Information($"Метод Foo був викликаний о {DateTime.Now}");
        
    
    }

}
