// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int a = 456;
Console.WriteLine($"Вторая цифра {a}  - {(a / 10) % 10}");

int b = 782;

Console.WriteLine($"Вторая цифра {b}  - {(b / 10) % 10}");

int c = 918;

Console.WriteLine($"Вторая цифра {c}  - {(c / 10) % 10}");
