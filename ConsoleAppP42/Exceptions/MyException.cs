using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Exceptions;

//[Serializable] // Дозволяє серіалізацію виключення
public class MyException: Exception
{
    public string ErrorCode { get; protected set; } = "MY_DEFAULT_ERROR_CODE";


    public MyException() { }
    public MyException(string message, string errorCode) : base(message) { ErrorCode = errorCode; }
    public MyException(string message, string errorCode, Exception inner) : base(message, inner) { ErrorCode = errorCode; }

    //// Конструктор для серіалізації
    //protected MyException(
    //  System.Runtime.Serialization.SerializationInfo info,
    //  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
