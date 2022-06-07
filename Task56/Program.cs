// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (var i = 0; i < rowNumber; i++)
    {
        for (var j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(0, deviation);
        }
    }
    return result;
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 65;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void RowSmallestSumElem(int[,] matr)
{
    int sumRow = 0; // сумма

    int minRow = 0; // индекс минимального

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0; // сумматор

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                sum += matr[i, j];
            }
        }
        Console.WriteLine($"Сумма элементов строк {i}: {sum} "); //вывод для промежуточного контроля
        if (i == 0) sumRow = sum;
        if (i != 0 && sumRow > sum) 
        {
            minRow = i;
            sumRow = sum;
        }
    }
    Console.WriteLine();
    Console.Write($"строка {minRow} с наименьшей суммой элементов; ");
}


int[,] randomArray = FillArray(13, 4, 5);
print2DArray(randomArray);

RowSmallestSumElem(randomArray);

