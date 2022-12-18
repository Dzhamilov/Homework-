/*Задача 2: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

 Console.Write("Введите первое число: ");
 double firstNumber = Convert.ToDouble(Console.ReadLine());
 Console.Write("Введите второе число: ");
 double secondNumber = Convert.ToDouble(Console.ReadLine());
 double max = firstNumber;
 if (max < secondNumber)
    Console.WriteLine($"{secondNumber} больше чем {firstNumber}");
 else Console.WriteLine($"{firstNumber} больше чем {secondNumber} ");