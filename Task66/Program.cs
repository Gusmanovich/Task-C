﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElem(int min, int max)
{
    if (max == min)
    {
        return max;
    }
    else
    {
        return max + SumElem(min, max - 1);
    }
}

Console.WriteLine(SumElem(4, 8));
