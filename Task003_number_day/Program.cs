// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
//     5 -> Пятница

Console.Write("Введите номер дня недели: ");
int number_week = int.Parse(Console.ReadLine());
if (0 < number_week && number_week < 8)
{
    if (number_week == 1) Console.WriteLine("Понедельник");
    else if (number_week == 2) Console.WriteLine("Вторник");
    else if (number_week == 3) Console.WriteLine("Среда");
    else if (number_week == 4) Console.WriteLine("Четверг");
    else if (number_week == 5) Console.WriteLine("Пятница");
    else if (number_week == 6) Console.WriteLine("Суббота");
    else if (number_week == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Введён не правильный день недели");    
}