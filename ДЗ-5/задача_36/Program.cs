/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

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

int[] array = GetArray(6, -9, 10);
int sumOdd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0 ) sumOdd += array[i];
}

Console.WriteLine((string.Join(", ", array )) + " -> " + sumOdd);
