// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

int[] ManyInOne(int[,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[k] = array[i, j];
            k++;
        }
    }
    return temp;
}

int[] BableSort(int[] array)
{
    int size = array.Length;
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        for (int k = 0; k < size - 1 - i; k++)
        {
            if (array[k] > array[k + 1])
            {
                temp = array[k + 1];
                array[k + 1] = array[k];
                array[k] = temp;
            }
        }
    }
    return array;
}

void FrequencyDictionary(int[] array)
{
    int count = 1;
    int size = array.Length;

    for (int k = 0; k < size - 1; k++)
    {
        if (array[k] == array[k + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array[k]} встречается {count}");
            count = 1;
        }
    }
    Console.WriteLine($"{array[size - 1]} встречается {count}");
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

int[] Temp = ManyInOne(myArray);
Console.WriteLine(String.Join(" ", Temp));

int[] SortTemp = BableSort(Temp);
Console.WriteLine(String.Join(" ", SortTemp));

FrequencyDictionary(SortTemp);
