/*Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int ReadNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void SummNumber(int number)
{
    int n = number,
        sum = 0,
        digit = 0;
    while(n > 0)
    {
        digit = n % 10;
        sum += digit;
        n /= 10;
    }
    Console.Write($"{number} -> {sum}");
}

int number = ReadNumber("Введите число: ");

SummNumber(number);