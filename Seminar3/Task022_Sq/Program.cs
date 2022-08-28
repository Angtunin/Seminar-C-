// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число от 1 до N: ");
int num = int.Parse(Console.ReadLine());
int index = 1;

while (index <= num)
{
    Console.Write($"{index * index}, ");
    index++;
}

// Решение циклом for
Console.WriteLine();

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i * i}, ");
}
