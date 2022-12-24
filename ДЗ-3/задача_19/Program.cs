/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите целое пятизначное число: ");
string userNumber = Console.ReadLine();
int Number = int.Parse(userNumber);
if(userNumber.Length == 5)
{
    if(userNumber[userNumber.Length-1] == userNumber[0] & userNumber[userNumber.Length-2] == userNumber[1])
    Console.WriteLine($"{Number} => да ");
    else Console.WriteLine($"{Number} => нет ");
}
else Console.WriteLine("Введите корректное, целое пятизначное число");