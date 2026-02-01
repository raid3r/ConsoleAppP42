using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Delegates;

/*
   Action<T> (T) => void
   Func<T, TResult> (T) => TResult
   
   Predicate<T>  (T) => bool   Func<T, bool>
   Comparison<T> (T, T) => int   Func<T, T, int>  -1,0,1 
*/

public class SomeGeneric<T> where T : class
{
    public delegate T MyGenericDelegate(T param);


    public void Print(List<T> items, Action<T> printAction)
    {
        items.ForEach(printAction);
    }

    //public delegate int MyGenericIntDelegate(T param);

    //public delegate void OnPrint(T param);

    public event Action<T> PrintEvent = (T p) => {
        Console.WriteLine(p.ToString());
    };

    public event Func<T, int> GenericEvent = (T p) =>
    {
        return 1;
    };

}
