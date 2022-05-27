/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] GenerateArray(int length, int lowerBorder, int upperBorder)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(lowerBorder, upperBorder + 1);
    }
    return result;
}

void printArray(int[] arrayToPrint, string name = "")
{
    Console.ForegroundColor=ConsoleColor.Green;

    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"Массив {name}");
    }
    Console.WriteLine("------------------------------------------------");
    Console.ForegroundColor=ConsoleColor.White;

    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine();
}
int[] ReverseArray(int[] arrayToReverse)
{
    int[] result = new int[arrayToReverse.Length];
    for (var i = 0; i < arrayToReverse.Length; i++)
    {
        result[i] = arrayToReverse[arrayToReverse.Length -1 - i];
    }
    return result;
}


Console.Clear();
int[] arrayToReverse = GenerateArray(5,-10,10);
printArray(arrayToReverse, "Начальный");

int[] reversedArray = ReverseArray(arrayToReverse);
printArray(reversedArray, "Перевернутый");