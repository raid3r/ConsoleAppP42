using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppP42.Overload;

public class CreditCard
{
    public string Name { get; set; } = string.Empty;

    private string _validTo = string.Empty;
    public string ValidTo
    {
        get
        {
            return _validTo;

        }
        set
        {
            // 10/2025
            if (!DateValidTo(value))
            {
                throw new Exception("Invalid date");
            }

            _validTo = value;
        }
    }

    private string _cardNumber = string.Empty;
    public string CardNumber
    {
        get
        {
            return _cardNumber;
        }
        set
        {
            //clear with LINQ 
            //var cleared = string.Join("", value.ToArray().Where(x => char.IsDigit(x)));
            //regex clear
            var cleared = Regex.Replace(value, @"[^\d]", "");

            if (cleared.Length < 16)
            {
                throw new Exception("Invalid card number (< 16)");
            }
            if (!CheckNumber(cleared)) {
                throw new Exception("Invalid card number (check sum)");
            }

            _cardNumber = value;
        }
    }

    public static bool DateValidTo(string value)
    {
        var date = DateTime.ParseExact(value, "MM/yyyy", CultureInfo.InvariantCulture);
        var validUntill = date.AddMonths(1).AddDays(1 - date.Day);
        return DateTime.Now < validUntill;
    }

    public static bool CheckNumber(string cardNumber)
    {
        int sum = 0;
        for (var i = 0; i < cardNumber.Length; ++i)
        {
            int digit = cardNumber[i] - '0';

            if (i % 2 == 0)
            {
                digit *= 2;
            }

            if (digit > 9)
            {
                digit -= 9;
            }

            sum += digit;
        }

        return sum % 10 == 0;
    }


    public override string ToString()
    {
        return $"Card: {CardNumber}\nValid to: {ValidTo}";
    }

}

/*
 * 
 * творіть клас "Кредитна картка". Вам необхідно зберігати інформацію про номер картки, 
ПІБ власника, CVC, дату завершення роботи картки тощо. 
Передбачити механізми для ініціалізації полів класу. 
Якщо значення для ініціалізації невірне, генеруйте виключення.
Карта в форматі 1111-1111-1111-1111 або без - підряд 1111111111111111
Дата завершення вводиться в форматі 10/2025 - місяць/рік
Для перевірки валідності номера карти реалізувати алгоритм Луна https://uk.wikipedia.org/wiki/%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC_%D0%9B%D1%83%D0%BD%D0%B0

можливі помилки
- пусте ім'я
- невалідний номер карти
- CVC номер не 3 цифри
- Дата та рік завершення пройшли (10/2025)

Дані отримувати від користувача
 * 
 */