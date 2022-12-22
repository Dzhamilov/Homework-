/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите целое трёхзначное число: ");
string str = Console.ReadLine();
if(str.Length == 3)
{
    int thirdNumber = int.Parse(str);
    int secondNumber = thirdNumber % 100;
    int firsNumber = secondNumber % 10;
    int result = (secondNumber - firsNumber) / 10;
    Console.WriteLine($"вторая цифра этого числа {thirdNumber} = {result}");
}
if(str.Length > 3)
    Console.WriteLine("Вы ввели больше трёхзначного");
if(str.Length < 3)
    Console.WriteLine("Вы ввели меньше трёхзначного");
else 
    Console.WriteLine("Введите корректное число");


