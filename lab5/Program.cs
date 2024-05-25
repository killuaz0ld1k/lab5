using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Консольный калькулятор");

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите оператор (+, -, *, /): ");
        char op = Console.ReadLine()[0];

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool isValidOperation = true;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    isValidOperation = false;
                }
                else
                {
                    result = num1 / num2;
                }
                break;
            default:
                Console.WriteLine("Неверный оператор");
                isValidOperation = false;
                break;
        }

        if (isValidOperation)
        {
            Console.WriteLine("Результат: " + result);
        }
    }
}


