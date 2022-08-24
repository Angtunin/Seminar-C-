Console.WriteLine("Введите первое число ");
Console.WriteLine("Введите второе число ");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
if (number_1 == Convert.ToInt32(Math.Pow(number_2, 2)))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}