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


// Второй вариант решения:

// Console.Write("Введите номер дня недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// switch (dayNumber)
// {
//     case 6: case 7:
//         Console.WriteLine($"День недели номер {dayNumber} является выходным.");
//         break;

//     case 1: case 2: case 3: case 4: case 5:
//         Console.WriteLine($"День недели номер {dayNumber} не является выходным.");
//         break;

//     default:
//         Console.WriteLine($"Дня недели с номером {dayNumber} нет.");
//         break;
// }