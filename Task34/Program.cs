// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, deviation + 1);
    }
    return result;
}

void printArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(",  ");
        }
    }
    Console.WriteLine("]");
}

int amountOfNumbers(int[] arrayToCalculate)
{
    int result = 0;
    for (var i = 0; i < arrayToCalculate.Length; i++)
    {
        if (arrayToCalculate[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] randomArray = getRandomArray(4, 999);
int evenNumbers = amountOfNumbers(randomArray);

printArray(randomArray);
Console.WriteLine($"количество чётных чисел в массиве:    {evenNumbers}");
