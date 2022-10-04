// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void ShowNumbers(int digit, string linetoPrint)
{
    if (digit == 1)
    {
        linetoPrint = digit.ToString() + linetoPrint;
        Console.Write($"{linetoPrint}");
    }
    else
    {
        linetoPrint = ", " + digit.ToString() + linetoPrint;
        ShowNumbers(digit - 1, linetoPrint);
    }
}

Console.Write("Введите число n: ");
int digit = int.Parse(Console.ReadLine());
ShowNumbers(digit, "");
