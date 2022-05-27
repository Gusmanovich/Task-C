// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumElementsOfArray(int[] arrayToCalculate)
{
    int result = 0;
    for (var i = 1; i < arrayToCalculate.Length; i += 2)
    {

        result += arrayToCalculate[i];

    }
    return result;
}

int[] randomArray = getRandomArray(9, 100);
int SumElements = sumElementsOfArray(randomArray);

printArray(randomArray);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях:    {SumElements}");