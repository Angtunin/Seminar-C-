// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] GetArray(int m, int n, int mimValut, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(mimValut, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[] MinElement(int[,] array)
{
    int[] IndexMin = new int[2];
    int resMin = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (resMin > array[i, j])
            {
                resMin = array[i, j];
                IndexMin[0] = i;
                IndexMin[1] = j;
            }

        }
    }
    return IndexMin;
}

int[,] ResizeArray(int[,] array, int[] index)
{
    int k = 0, l = 0;

    int[,] ResizeArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != index[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (j != index[1])
                {
                    ResizeArray[k, l] = array[i, j];
                    l++;
                }
            }
            l = 0;
            k++;
        }
    }
    return ResizeArray;
}


Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальную границу диапазон: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную границу диапазон: ");
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();

int[] MinIndex = MinElement(myArray);
Console.WriteLine(String.Join(" ", MinIndex));

int[,] ResezeArr = ResizeArray(myArray, MinIndex);

PrintArray(ResezeArr);
