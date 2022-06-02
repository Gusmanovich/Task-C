// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void InputOfArrayElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arrayToPrint)
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

void CountingElem(int[] arrayToCount)
{
    int positive = 0;
    for (int i = 0; i < arrayToCount.Length; i++)
    {
        if (arrayToCount[i] > 0)
        {
            positive++;
        }
    }
    Console.Write($"Общее количество положительных элементов массива:  {positive}");
}




Console.Write("Введите количество чисел для ввода: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];

InputOfArrayElements(array);

PrintArray(array);

CountingElem(array);