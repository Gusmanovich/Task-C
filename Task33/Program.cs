// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool FindItem(int[] collection, int search)
{
    int length = collection.Length;
    int index = 0;
    bool result = false;

    while (index < length)
    {
        if (collection[index] == search)
        {
            result = true;
        }
        index ++;
    }
    return result;
}


Console.Write("Введите число элементов массива: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];


FillArray(array);

PrintArray(array);

Console.WriteLine();

Console.Write("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());
find = Math.Abs(find);

bool hasNumber = FindItem(array, find);

Console.WriteLine((hasNumber)?"Да":"Нет");


