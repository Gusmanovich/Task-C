// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = 3;
int x2 = 2;
int y1 = 6;
int y2 = 1;
int z1 = 8;
int z2 = -7;

double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine(a);
Console.WriteLine(string.Format("{0:0.##}", a));
double b = Math.Round(a, 3);
Console.WriteLine(b);