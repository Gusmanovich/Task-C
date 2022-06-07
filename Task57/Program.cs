// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

void printArray(int[] arrayToPrint)
{
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        if (arrayToPrint[i] != 0)
        {
            Console.WriteLine($"{i} встречается {arrayToPrint[i]} раз...");
        }
    }
}
void FrequencyDictionaryArrayElem(int[,] arrayTo)
{
    for (int k = 0; k < 10; k++)  // возможные элементы массива от 0 до 9
    {
        int result = 0; // количество одинаковых элементов в массиве
        for (int i = 0; i < arrayTo.GetLength(0); i++)
        {
            for (int j = 0; j < arrayTo.GetLength(1); j++)
            {
                if (k == arrayTo[i, j])
                {
                    result++;
                }
            }
        }
        if (result != 0)
        {
            Console.WriteLine($"{k} встречается {result} раз...");
        }
    }
    Console.WriteLine();
}

int[] FrequencyDictionaryArrayElemToArr(int[,] array)
{
    int[] arr = new int[10];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[array[i, j]]++;
        }
    }
    return arr;
}


int[,] randomArray = FillArray(3, 4, 10);

print2DArray(randomArray);

FrequencyDictionaryArrayElem(randomArray);

printArray(FrequencyDictionaryArrayElemToArr(randomArray));









