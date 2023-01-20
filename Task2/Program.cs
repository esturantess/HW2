// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
// 645 -> 5
//
// 78 -> третьей цифры нет
//
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;

if (num >= 100)
{
    while (num1 >= 1000)
    {
        num1 = (num1 / 10);
    }
    Console.WriteLine($"Третья цифра числа {num}: {num1 % 10}");
}
else
{
    Console.WriteLine($"Третьей цифры в числе {num} нет.");
}

// Второй способ решения:

// Console.Write("Введите число: ");
// String text = Console.ReadLine();
// if (text.Length < 3)
// {
//     Console.WriteLine($"Третьей цифры в числе {text} нет.");
// }
// else
// {
//     Console.WriteLine($"Третья цифра числа {text}: {text[2]}");
// }