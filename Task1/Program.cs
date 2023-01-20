// Задача: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Первый способ решения:

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num < 1000)
// {
//     Console.WriteLine($"Вторая цифра числа {num}: {(num - ((num / 100) * 100)) / 10}");
// }
// else
// {
//     System.Console.WriteLine("Введенное число не является трехзначным.");
// }

// Второй способ решения:

Console.Write("Введите трёхзначное число: ");

String text = Console.ReadLine();
if (text.Length == 3)
    {
        System.Console.WriteLine($"Вторая цифра числа {text}: {text[1]}");
    }
else
    {
        System.Console.WriteLine("Введенное число не является трехзначным.");
    }