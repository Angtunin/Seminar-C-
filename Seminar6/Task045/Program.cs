// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] array)
{
    int[] res = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = array[i];
    }
    return res; 
}

int[] myArray = GetArray(5, -5, 5);
Console.WriteLine($"первоначальный массив [{String.Join(" ", myArray)}]");

Console.WriteLine($"копия массива [{String.Join(" ", CopyArray(myArray))}]");