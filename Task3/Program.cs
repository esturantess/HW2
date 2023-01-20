// Задача: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <= 7)
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine($"День недели номер {dayNumber} является выходным.");
    }
    else
    {
        Console.WriteLine($"День недели номер {dayNumber} не является выходным.");
    }
else
{
    Console.WriteLine($"Дня недели с номером {dayNumber} нет.");
}