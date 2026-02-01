using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Extensions;

public static class RectangleExtension
{
    public static double Area(this Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}

public static class Int32Extension
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
}


public static class  StringExtension
{

    //* 2) кількість слів у повідомленні.
    public static int WordCount(this string message)
    {
        var words = message.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }


    public static string ReplaceVowelsWithChar(this string message, char replaceTo)
    {
        var vowels = "aeiouAEIOU";
        var result = new StringBuilder(message.Length);
        foreach (var ch in message)
        {
            if (vowels.Contains(ch))
            {
                result.Append(replaceTo);
            }
            else
            {
                result.Append(ch);
            }
        }
        return result.ToString();
    }




     //* 5) повідомлення з заміною голосних літер на '*'.
}
