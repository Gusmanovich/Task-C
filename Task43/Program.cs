// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double[] IntersectionPoint(double a1, double c1, double a2, double c2)
{
    double[] result = new double[2];

    result[0] = (c2 - c1) / (a1 - a2);

    result[1] = a2 * result[0] + c2;

    return result;
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(",  ");
        }
    }
    Console.WriteLine("]");
}


Console.Write("Введите число k1 в формуле y = k1 * x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b1 в формуле y = k1 * x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2 в формуле y = k2 * x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2 в формуле y = k2 * x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] array = IntersectionPoint(k1, b1, k2, b2);

PrintArray(array);