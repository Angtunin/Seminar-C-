// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FibArray(int Num)
{
    int[] res = new int[Num];
    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < Num; i++)
    {
        res[i] = res[i - 1] + res[i - 2];
    }
    return res;
}

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
int[] myArray = FibArray(Num);
Console.WriteLine($"F({Num}) = {String.Join(" ", myArray)}");