/*Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("Введите положительное число: ");
 double Number = Convert.ToDouble(Console.ReadLine());
 int i = 1;
while (i <= Number)
    if (i % 2 == 0)
    {
        Console.Write($"{i}; ");
        i++;
    }else i++;