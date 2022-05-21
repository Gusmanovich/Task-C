// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int digit;
int sum = 0;

while (num > 0)
{
    digit = num % 10;
    sum += digit;
    num = num / 10;
}
Console.WriteLine($"Сумма цифр в числе: {sum}");