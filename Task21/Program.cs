// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int x1 = 3;
int x2 = 2;
int y1 = 6;
int y2 = 1;

double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(a);
Console.WriteLine(string.Format("{0:0.##}", a));
double b = Math.Round(a, 3);
Console.WriteLine(b);