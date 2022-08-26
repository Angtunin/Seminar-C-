// Напишите программу, которая на вход принимает число и выдаёт 
// его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Результат = {0}", sqr);
Console.WriteLine($"Результат = {sqr}");
int result = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Результат = {Math.Pow(number, 2)}");
