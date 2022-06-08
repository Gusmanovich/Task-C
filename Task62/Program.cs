// Задача 62. Заполнить спирально массив 4 на 4
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int[,] FillSpiralArray(int[,] array)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = array.GetLength(1);

    for (int i = 0; i < array.Length; i++)   // array.Length - в двумерном массиве общее количество элементов
    {
        array[row, col] = i + 1;
        //Console.Write($"{row}, {col} - {array[row, col]}\t");
        if (--visits == 0)
        {
            visits = array.GetLength(1) * (dirChanges % 2) + array.GetLength(0) * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        
        col += dx;
        row += dy;
        
        
    }
    return array;
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

const int n = 3;
const int m = 3;
int[,] matrix = new int[n, m];

FillSpiralArray(matrix);

Console.WriteLine();
print2DArray(matrix);
