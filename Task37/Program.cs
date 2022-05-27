// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] multElementsOfArray(int[] arrayToCalculate)
{
    int length = 0;
    bool medium = false;
    if (arrayToCalculate.Length % 2 != 0)
    {
        length = (arrayToCalculate.Length / 2) + 1;
        medium = true;
    }
    else
    {
        length = (arrayToCalculate.Length / 2);
    }
    int[] arr = new int[length];

    for (var i = 0; i < length; i++)  
    {
        if (medium)
        {
            int temp = arrayToCalculate[length - 1];
            arr[i] = arrayToCalculate[i] * arrayToCalculate[arrayToCalculate.Length - 1 - i];
            arr[length - 1] = temp;
        }
        else
        {
            arr[i] = arrayToCalculate[i] * arrayToCalculate[arrayToCalculate.Length - 1 - i];
        }
    }
    return arr;
}

// работает и для четного и для нечетного количества элементов массива
int[] randomArray = getRandomArray(9, 10);  
int[] multElements = multElementsOfArray(randomArray);

printArray(randomArray);

Console.WriteLine($"произведение пар чисел в одномерном массиве:");

printArray(multElements);