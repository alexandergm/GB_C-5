using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Выберите операцию (+, -, *, /) или нажмите Enter для выхода: ");
            string operation = Console.ReadLine();
            if (operation == "")
            {
                break;
            }
            else if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Некорректная операция");
                continue;
            }

            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Некорректное значение");
                continue;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Некорректное значение");
                continue;
            }

            double result;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                default:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно");
                        continue;
                    }
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
