/*Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/

Console.Write("Введите число: ");
 double Number = Convert.ToDouble(Console.ReadLine());
if(Number % 2 ==0)
    Console.WriteLine($"{Number} >> чётное"); 
else Console.WriteLine($"{Number} >> нечётное"); 