Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int current = -number;
if (current < number)
{
    while (current <= number)
    {
        Console.Write($"{current} ");
        current++;
    }
}
else
{
    while (number <= current)
    {
        Console.Write($"{number} ");
        number++;
    }
}