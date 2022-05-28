// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int[] SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] randomArray = getRandomArray(number, 10); 

printArray(randomArray); // неотсортированный массив

int[] arr = SelectionSort(randomArray); // Получается можно не создавать новый массив?

printArray(randomArray); // отсортированный массив  ПОЧЕМУ????? только arr должен быть по идее отсортирован?

Console.WriteLine($"разницу между максимальным и минимальным элементов массива: {arr[arr.Length-1]} - {arr[0]} =  { arr[arr.Length-1] - arr[0]}");

