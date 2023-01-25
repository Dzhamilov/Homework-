/* Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет */

int[,] GetMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix; 
}


Console.Write("Введите номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = GetMatrix(4,5);
if(m <= matrix.GetLength(0) && n <= matrix.GetLength(1)) Console.WriteLine($"По заданной позиции такое значение -> {matrix[m-1, n-1]}");
else Console.WriteLine("Такой позиции в массиве не существует ");