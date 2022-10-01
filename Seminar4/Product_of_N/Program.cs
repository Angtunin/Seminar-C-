// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ProductN(int number)
{
    int sumN = 1;
    for (int i = 1; i <= number; i++)
    {
        sumN = sumN * i;
    }
    return sumN;
}

Console.Write("Введите число: ");
int numPN = int.Parse(Console.ReadLine());
Console.WriteLine($"{ProductN(numPN)}");
