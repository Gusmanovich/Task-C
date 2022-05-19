// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Ввидите число:   ");
int number22 = Convert.ToInt32(Console.ReadLine());
int result;

Console.Write($"{number22} - >  ");
for (int i = 1; i <= number22; i++)
{
    result = i * i;
    Console.Write(result);
    if (i != number22)
    {
        Console.Write(",  ");
    }
}

