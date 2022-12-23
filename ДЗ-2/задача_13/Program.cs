/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите целое число: ");
string str = Console.ReadLine();
int userNumber = int.Parse(str);
if(str.Length >= 3)
{
    Console.WriteLine($"третья цифра этого числа {userNumber} -> {str[2]}");
    return;
}
if(str.Length < 3)
    Console.WriteLine("третьей цифры нет");
else 
    Console.WriteLine("Введите корректное число");