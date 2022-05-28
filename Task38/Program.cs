// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] getRandomArray(int length, int deviation)
{
    double[] result = new double[length];
    //Random rand = new Random();
    for (var i = 0; i < length; i++)
    {
        //result[i] = new Random().Next(0, (deviation * 1000 + 1)) * 0.001;
        result[i] = new Random().Next(0, deviation) + new Random().NextDouble();

    }
    return result;
}

void printArray(double[] arrayToPrint)
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

double[] SelectionSort(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите возможное максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] randomArray = getRandomArray(number, max);

printArray(randomArray); // неотсортированный массив

double[] arr = SelectionSort(randomArray); // Получается можно не создавать новый массив?

Console.WriteLine("Отсортированный массив: ");

printArray(randomArray); // отсортированный массив  ПОЧЕМУ????? только arr должен быть по идее отсортирован?

Console.WriteLine($"разницу между максимальным и минимальным элементов массива: {arr[arr.Length - 1]} - {arr[0]} =  {Math.Round(arr[arr.Length - 1] - arr[0],3)}");

