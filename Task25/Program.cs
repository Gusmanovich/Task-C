// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:   ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень В:   ");
int b = Convert.ToInt32(Console.ReadLine());

int mathDegree = 1; // при условии (b == 0 && a != 0)

for (int i = 1; i <= b; i++)
{
    mathDegree = mathDegree * a;
}


Console.WriteLine($"число {a} в натуральной степени {b}  равно {mathDegree}");