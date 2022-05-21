// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число:   ");
int num = Convert.ToInt32(Console.ReadLine());
int mult = 1;

if (num>=0)
{
    for (int i = 1; i <= num; i++)
    {
        mult = mult *i;
    }
}

Console.WriteLine($"Произведение чисел от 1 до {num} равно {mult}");