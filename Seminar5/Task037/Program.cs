// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] MultiNum(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size++;

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[(array.Length - 1) - i];
    }
    if (array.Length % 2 != 0) result[(array.Length / 2)] = array[(array.Length / 2)];
    return result;
}
      
int[] myArray = GetArray(5, 1, 5);
Console.WriteLine(String.Join(" ", myArray));

Console.WriteLine(String.Join(" ", MultiNum(myArray)));
