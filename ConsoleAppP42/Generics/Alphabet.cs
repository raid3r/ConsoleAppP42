using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Generics;

public class Alphabet : IEnumerable<char>
{
    private readonly string letters = "ABC";

    public IEnumerator<char> GetEnumerator()
    {
        return letters.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
