// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

void SumMainDiagonalArray(int[,] array)
{
    int sumDiag = 0;
    Console.Write($"Сумма главной диагонали ");  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sumDiag = sumDiag + array[i, j];
                Console.Write($"{array[i, j]} ");     
            }
        }
    }
    Console.WriteLine($"= {sumDiag}");    
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

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();
SumMainDiagonalArray(myArray);