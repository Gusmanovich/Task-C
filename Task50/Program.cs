// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
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

void ElementSearch(int[,] matr, int findNum)
{
    if (findNum >= matr.GetLength(0) * matr.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        int row = findNum / matr.GetLength(1);
        int col = findNum - row * matr.GetLength(1);
        Console.Write($"Искомое число находится на позиции {row}, {col}  двумерного массива с элементом  :");
        Console.WriteLine($" {matr[row, col]}");
    }
}

Console.Write("Введите позицию элемента в двумерном массиве: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = FillArray(3, 4, 9);

print2DArray(randomArray);

ElementSearch(randomArray, elemNum);
