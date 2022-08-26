// 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int number1 = number / 100;
int number2 = number % 10;
int numberNew = number1 * 10 + number2;

Console.WriteLine($"{number}, {numberNew}"); 