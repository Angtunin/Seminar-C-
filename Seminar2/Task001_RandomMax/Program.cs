// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
//Console.WriteLine(number); // вариант вывода ниже 
int number1 = number / 10;
int number2 = number % 10;
int Max = number1; 
if (number1 < number2)
{
    Max = number2;
}  

Console.WriteLine($"{number}, max число = {Max}");