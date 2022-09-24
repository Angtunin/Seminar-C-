// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string NumBinary(int Num)
{
    string BinNum = String.Empty;
    int res = 0;
    while (1 + Num != 1)
    {
        res = Num - (Num / 2) * 2;
        BinNum = BinNum + res.ToString();
        Num = Num / 2;
    }
    return BinNum;  
}

void ReverseArr(char[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        char temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;   
    }
    
}

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine(NumBinary(Num));

string myNum = NumBinary(Num);

char[] myArray = myNum.ToCharArray();

ReverseArr(myArray);

Console.WriteLine(String.Join(" ", myArray));