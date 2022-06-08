// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] numbers = new int[100]; // массив чтобы отмечать уникальные значения 

int GetNumberOfUniq(int[] array)
{
    int result = new int();
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == 1)
        {
            result++;
        }
    }
    return result;
}



int GetUniqNumber()
{
    bool uniq = false;
    int result = new int();
    while (!uniq)
    {
        result = new Random().Next(10, 100); // result значения элементов массива
        if (numbers[result] == 0)    // пока не присвоено данному элементу значение
        {
            numbers[result] = 1;
            uniq = true;
            break;
        }
        else
        {
            int countUniq = GetNumberOfUniq(numbers);
            Console.WriteLine($"повтор {countUniq}");
            if (countUniq == 90)
            {
                Console.WriteLine("Все двузначные числа использованы");
                break;
            }
        }
    }
    return result;
}

int[,,] Generate3DArray(int rowsNumber, int colsNumber, int depthNumber)
{
    int[,,] result = new int[rowsNumber, colsNumber, depthNumber];
    for (var i = 0; i < rowsNumber; i++)
    {
        for (var j = 0; j < colsNumber; j++)
        {
            for (int z = 0; z < depthNumber; z++)
            {
                result[i, j, z] = GetUniqNumber();
            }
        }
    }
    return result;
}

void print3DArray(int[,,] arrayToPrint, int oneLineLength)
{
    int currentLength;
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        currentLength = 0;
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int z = 0; z < arrayToPrint.GetLength(2); z++)
            {
                Console.Write($"[{i},{j},{z}]: {arrayToPrint[i, j, z]}\t");
                if (currentLength == oneLineLength - 1)
                {
                    Console.WriteLine();
                    currentLength = 0;
                }
                else
                {
                    currentLength++;
                }
            }

        }
        Console.WriteLine();
    }
}

const int rowsNumber = 10;
const int colsNumber = 7;
const int depthNumber = 2;
int[,,] gener3DArray = Generate3DArray(rowsNumber, colsNumber, depthNumber);
print3DArray(gener3DArray, 5);