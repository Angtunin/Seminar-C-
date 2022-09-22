// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



bool NumIn(int[] array, int Num)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num) return true;
    
    }
    return false;
    
}
int[] myArray = {6, 7, 19, 345, 3};
Console.Write("Введите число для проверки: ");
int Num = int.Parse(Console.ReadLine());

if (NumIn(myArray, Num))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");    
}
 




