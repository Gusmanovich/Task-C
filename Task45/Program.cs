// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

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
int[] CopyArray(int[] arrayToCopy)
{
    int[] result = new int[arrayToCopy.Length];
    for (var i = 0; i < arrayToCopy.Length; i++)
    {
        result[i] = arrayToCopy[i];
    }
    return result;
}


Console.Clear();
int[] arrayToCopy = GenerateArray(5,-10,10);
printArray(arrayToCopy, "Начальный");

int[] copiedArray = CopyArray(arrayToCopy);
printArray(copiedArray, "Скопированный");