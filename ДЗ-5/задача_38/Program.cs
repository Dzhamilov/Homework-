/* Задайте массив натуральных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76   */

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

int maxElement(int[] array)
{
    int maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNumber) maxNumber = array[i];
    }
    return maxNumber;
}

int minElement(int[] array)
{
    int minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNumber) minNumber = array[i];
    }
    return minNumber;
}
int[] array = GetArray(6, 0, 100);
int diffMaxMin = maxElement(array) - minElement(array);
Console.WriteLine((string.Join(", ", array )) + " -> " + diffMaxMin);

