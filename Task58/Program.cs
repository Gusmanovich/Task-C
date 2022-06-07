// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// m = len(a)                                            # a: m × n
// n = len(b)                                            # b: n × k
// k = len(b[0])

// c = [[None for __ in range(k)] for __ in range(m)]    # c: m × k

// for i in range(m):
//     for j in range(k):       
//         c[i][j] = sum(a[i][kk] * b[kk][j] for kk in range(n))


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

int[,] MultMatrix(int[,] matr1, int[,] matr2)
{
    int i = matr1.GetLength(0);  // matr1: i x k
    int k = matr2.GetLength(0);  // matr2: k x j
    int j = matr2.GetLength(1);  // matr2: k x j
    
    int[,] mult = new int[i, j];  // mult: i x j

    for (i = 0; i < mult.GetLength(0); i++)
    {
        for (j = 0; j < mult.GetLength(1); j++)
        {
            for (k = 0; k < matr2.GetLength(0); k++)
            {
                mult[i,j] += matr1[i,k] * matr2[k,j];
                                
            }

        }
    }
    return mult;
}

int[,] randomArray1 = FillArray(2, 3, 5);

int[,] randomArray2 = FillArray(3, 4, 5);

Console.WriteLine($"Первая матрица {randomArray1.GetLength(0)} на {randomArray1.GetLength(1)} :");

print2DArray(randomArray1);

Console.WriteLine($"Вторая матрица {randomArray2.GetLength(0)} на {randomArray2.GetLength(1)} :");

print2DArray(randomArray2);

if (randomArray1.GetLength(1) == randomArray2.GetLength(0))
{
    Console.WriteLine("произведение двух матриц");
    print2DArray(MultMatrix(randomArray1, randomArray2));
}
else
{
    Console.WriteLine("Количество столбцов матрицы 1 должно быть равно количеству строк матрицы 2");
}
