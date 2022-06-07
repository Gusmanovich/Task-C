// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

//  не все элементы массива просматриваются, выбирается первый минимальный. Кода больше, действий меньше?
int[] FindIndexMinElemArray(int[,] arrayTo)
{
    int[] arr = new int[2]; //координаты минимального элемента

    for (int k = 0; k < 10; k++)  // возможные элементы массива от 0 до 9
    {
        for (int i = 0; i < arrayTo.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTo.GetLength(1); j++)
            {
                if (k == arrayTo[i, j])
                {
                    arr[0] = i;
                    arr[1] = j;
                    Console.WriteLine($"Строка с минимальным значением  -  {arr[0]}");
                    Console.WriteLine($"Столбец с минимальным значением -  {arr[1]}");

                    goto Found;
                }
            }
        }
    }
Found:
    return arr;
}

int[,] DeletingRowColumnMatrix(int[,] arrayToDeleting, int[] indexMinElem)
{

    int row = arrayToDeleting.GetLength(0) - 1;
    int col = arrayToDeleting.GetLength(1) - 1;
    int i1, j1;
    int[,] result = new int[row, col]; // у исходного и у результирующего матриц разные индексы

    for (var i = 0; i < row; i++)
    {
        if (i >= indexMinElem[0])
        {
            i1 = i + 1;
        }
        else
        {
            i1 = i;
        }
        for (var j = 0; j < col; j++)
        {
            if (j >= indexMinElem[1])
            {
                j1 = j + 1;
            }
            else
            {
                j1 = j;
            }
            result[i, j] = arrayToDeleting[i1, j1];
        }
    }
return result;
}

int[,] randomArray = FillArray(4, 4, 10);

Console.WriteLine("Случайная матрица:");
print2DArray(randomArray);

int[] array = FindIndexMinElemArray(randomArray);

int[,] transformedMatrix = DeletingRowColumnMatrix(randomArray, array);

Console.WriteLine("Преобразованная матрица:");
print2DArray(transformedMatrix);
