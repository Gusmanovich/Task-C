// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NaturalNumbersN(int number, int current = 1)
{
    if (number < current)
    {
        return;
    }
    else
    {
        Console.Write(current);
        if (current < number)
        {
            Console.Write(", ");
        }
        NaturalNumbersN(number, current+1);
        
    }
}
NaturalNumbersN(5);


// второй вариант
void MagicIncrement(int a, int b)
{
    if (a > b)
    {
        MagicIncrement(a - 1, b);
        Console.Write(" " + a);
    }
    if (a < b)
    {
        Console.Write(" " + a);
        MagicIncrement(a + 1, b);
    }
    if (a == b) Console.Write(" " + a);

}

MagicIncrement(2,2);


// Третий вариант
string NumbersRec(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + NumbersRec(a + 1, b);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine();
Console.WriteLine(NumbersRec(1,10));