/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
int N = 5;
PrintNumber(N);
void PrintNumber(int n)
{
    if(n == 0) return;
    Console.Write(n + " ");
    PrintNumber(n-1);
}