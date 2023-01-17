/*  Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  
*/
int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(leftRange, rightRange);
    }

    return arr;
}

int[] array = GetArray(4, 100, 1000);
int even = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) even ++;
}

Console.WriteLine((string.Join(", ", array )) + " -> " + even);