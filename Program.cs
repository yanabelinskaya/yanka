using System;
using System.Runtime.Intrinsics.X86;

int operation;
double a, b, result;

do
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Сложить");
    Console.WriteLine("2. Вычесть");
    Console.WriteLine("3. Умножить");
    Console.WriteLine("4. Разделить");
    Console.WriteLine("5. Возвести в степень");
    Console.WriteLine("6. Найти квадратный корень");
    Console.WriteLine("7. Найти 1 процент");
    Console.WriteLine("8. Найти факториал");
    Console.WriteLine("9. Выйти");

    operation = Convert.ToInt32(Console.ReadLine());

    if (operation == 1)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());
        result = a + b;
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 2)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());
        result = a - b;
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 3)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());
        result = a * b;
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 4)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());
        result = a / b;
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 5)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        int n = Convert.ToInt32(Console.ReadLine());
        result = Math.Pow(a, n);
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 6)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToDouble(Console.ReadLine());
        result = Math.Sqrt(a);
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 7)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToDouble(Console.ReadLine());
        result = a / 100;
        Console.WriteLine("Результат: " + result);
    }
    else if (operation == 8)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToDouble(Console.ReadLine());
        double factorial = 1;
        for (int i = 1; i <= a; i++)
        {
            factorial *= 1;
            Console.WriteLine("Результат: " + factorial);
        }
    }
    else if (operation == 9)
    {
        Console.WriteLine("Выход из программы");
    }
} while (operation != 9);