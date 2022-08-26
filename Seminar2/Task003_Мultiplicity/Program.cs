// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int num1 = new Random().Next(1, 100);
// int num2 = new Random().Next(1, 100);
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"первое число = {num1}, второе число = {num2}");
if (num1 % num2 != 0)
{
    Console.WriteLine($"остаток = {num1 % num2}");
}
else
{
    Console.WriteLine("кратно");
}
