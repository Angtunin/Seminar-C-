// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти от 1 до 4: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
    Console.Write("x > 0, y > 0");
}
else
if (quarter == 2)
{
    Console.Write("x < 0, y > 0");
}
else
if (quarter == 3)
{
    Console.Write("x < 0, y < 0");
}
else
if (quarter == 4)
{
    Console.Write("x > 0, y < 0");
}
else
{
    Console.Write("Введите верное число от 1 до 4");    
}
