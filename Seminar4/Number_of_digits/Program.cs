// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Ndigits(int number)
{
    int i = 0;
    while (number != 0)
    {
        i++;
        number = number / 10;
    }
    return i;
}

Console.WriteLine("Введите число А:");
int num = int.Parse(Console.ReadLine());
Console.Write($"{Ndigits(num)}");