// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 5; N = 1. -> "5, 4, 3, 2, 1"
// M = 8; N = 4. -> "8, 7,6, 5, 4"

void MagicDecrement(int a, int b)
{
    if (a > b)
    {
        Console.Write($" {a},");   // переставляюся даже запятые для правильного вывода
        MagicDecrement(a - 1, b);
    }
    if (a < b)
    {
        MagicDecrement(a + 1, b);
        Console.Write($", {a}");
    }
    if (a == b) Console.Write(" " + a);

}

MagicDecrement(2, 5);
//MagicDecrement(5,2);


string NumbersRec(int a, int b)
{
    if (a > b)
    {
        return String.Empty;
    }
    else
    {
        return $"{NumbersRec(a + 1, b)} {a}";
    }
}

Console.WriteLine();
Console.WriteLine(NumbersRec(1,10));
