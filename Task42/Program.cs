// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int x = 3;
// string s = "";
// while (x > 0)
// {
//     s = ((x % 2 == 0) ? "0" : "1") + s;
//     x /= 2;
// }
// Console.Write(s);

int[] TransToBin(int num)
{
    int[] array = new int[8];
    for (int i = array.Length - 1; num > 0; i--)
    {
        array[i] = num % 2;
        num = num / 2;
    }
    return array;
}

// void PrintUsual(int [] arrayToPrint)
// {
//     for (int i = 0; i < arrayToPrint.Length; i++)
//     {
//         Console.Write(arrayToPrint[i]);
//     }
// }

void PrintArray(int[] arrayToPrint)
{
    bool firstOne = false;
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        if (!firstOne && arrayToPrint[i] == 1)
        {
            firstOne = true;
        }
        if (firstOne)
        {
            Console.Write(arrayToPrint[i]);
        }
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayBin = TransToBin(number);
// PrintUsual(arrayBin);
// Console.WriteLine();
PrintArray(arrayBin);
