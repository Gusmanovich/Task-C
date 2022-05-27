// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 200);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        Console.Write(col[position]);
        if (position != count - 1)
        {
            Console.Write(",  ");
        }
        position++;
    }
    Console.Write("]");
}

int FindRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>10 && array[i]<100)
        {
             count++;
        }
    }
    return count;
}



int[] array = new int[123];


FillArray(array);

PrintArray(array);

Console.WriteLine();

int count = FindRange(array);

Console.WriteLine($"Количество чисел в диапазоне от 10 до 99:  {count}");
