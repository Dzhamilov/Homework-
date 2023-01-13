/*Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран. Данные вводятся с консоли пользователем */

int[] GreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int[] array = GreateArray(8);
PrintArray(array);