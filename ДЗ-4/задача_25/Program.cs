/*Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Не использовать Math.Pow() и аналоги!*/

int ReadNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void PowNumber(int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number; 
    }
    Console.Write($"{number} ^ {degree} = {result}");
}

int number = ReadNumber("Введите число: ");
int degree = ReadNumber("Введите показатель степени: ");

PowNumber(number, degree);