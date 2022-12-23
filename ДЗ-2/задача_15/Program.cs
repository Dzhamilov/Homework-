/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет  */

Console.Write("Введите цифру обозначающую день недели: ");
int userNumber = int.Parse(Console.ReadLine());
switch(userNumber)
{
    case 1:
        Console.WriteLine($"{userNumber} -> нет");
        break;

    case 2:
        Console.WriteLine($"{userNumber} -> нет");
        break;

    case 3:
        Console.WriteLine($"{userNumber} -> нет");
        break;

    case 4:
        Console.WriteLine($"{userNumber} -> нет");
        break;

    case 5:
        Console.WriteLine($"{userNumber} -> нет");
        break;

    case 6:
        Console.WriteLine($"{userNumber} -> да");
        break;

    case 7:
        Console.WriteLine($"{userNumber} -> да");
        break;

    default:
        Console.WriteLine("эта цифра не обозначает день недели");
        break;
}
