// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 49 2
// 5 81 2 9
// 64 4 4 4

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

int[,] EevenIndexSquare(int[,] array)
{
    int sizeI = array.GetLength(0);
    int sizeJ = array.GetLength(1);
    int[,] result = new int[sizeI, sizeJ];

    for (int i = 0; i < sizeI; i++)
    {
        for (int j = 0; j < sizeJ; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                result[i, j] = array[i, j] * array[i, j];
                
            }
            else result[i, j] = array[i, j];
            
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
        
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);

Console.WriteLine();

int[,] myArray1 = EevenIndexSquare(myArray);
PrintArray(myArray1);
