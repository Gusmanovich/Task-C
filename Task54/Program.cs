// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArrayElem(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i,k] > matr[i,minPosition])
                {
                    minPosition = k;
                }
            }
            int temporary = matr[i,j];
            matr[i,j] = matr[i,minPosition];
            matr[i,minPosition] = temporary;
        }
    }
}

int[,] randomArray = FillArray(3, 4, 5);
print2DArray(randomArray);

SortArrayElem(randomArray);

Console.WriteLine("Отсортированный массив");

print2DArray(randomArray);