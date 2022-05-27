// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9, 10);
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

void Negative(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = collection[index] * -1;
        index++;
    }
}


Console.Write("Введите число элементов массива: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];

FillArray(array);

PrintArray(array);

Console.WriteLine();

Negative(array);

PrintArray(array);


