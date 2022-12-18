/*Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите первое число: ");
 double firstNumber = Convert.ToDouble(Console.ReadLine());
 Console.Write("Введите второе число: ");
 double secondNumber = Convert.ToDouble(Console.ReadLine());
  Console.Write("Введите третье число: ");
 double thirdNumber = Convert.ToDouble(Console.ReadLine());
 double max = firstNumber;
 if (max < secondNumber )
    max = secondNumber;
if (max < thirdNumber)
    max = thirdNumber;

 Console.WriteLine($"максимальное из трёх чисел: {firstNumber}; {secondNumber}; {thirdNumber}; >> {max}");