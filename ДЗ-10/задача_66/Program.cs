/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int M = 4,
    N = 8;
int sum = 0;
int SumNumber(int m, int n)
{
    if(m > n) return sum; 
    sum +=m;
    SumNumber(m+1, n);
    return sum;
}
int s = SumNumber(M, N);
Console.WriteLine(s);