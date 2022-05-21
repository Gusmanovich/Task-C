// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите количество элементов в массиве:  ");
int size = Convert.ToInt32(Console.ReadLine());

string[] inputValidationAnalysis() //анализ правильности ввода строки с числами
{
    string str;
    bool flag;
    string[] words = new string[size];

    do
    {
        Console.WriteLine($"Введите строку с положительными числами через запятую не более {size} чисел:  ");
        flag = true;
        str = Console.ReadLine() ?? " ";
        char[] charSeparators = new char[] { ',', ' ', '.' };

        words = str.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length > size)2б
        {
            Console.WriteLine($"Ввели более {size} чисел. Повторите ввод, пожалуйста:  "); 
            flag = false;
        }
        else
        {
            foreach (var word in words)
            {
                foreach (var item in word)
                {
                    if (!char.IsDigit(item))
                    {
                        Console.WriteLine("Ввели не число. Повторите ввод, пожалуйста:  "); //если хоть один символ не число, то выкидываешь "ложь"
                        flag = false;
                        break;
                    }
                }
            }
        }
    }
    while (!flag);
    return words;
}

int[] ConvertStr2IntArray(string[] words)
{
    int length = words.Length;
    int[] arr = new int[length];
    int index = 0;
    while (index < length)
    {
        arr[index] = Convert.ToInt32(words[index]);
        index++;
    }
    return arr;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");   
    while (position < count)
    {
        Console.Write(col[position]);
        if (position != count-1)
        {
            Console.Write(",  ");
        }
        position++;
    }
    Console.Write("]");
}

int[] array = new int[size];

string[] arrWords = inputValidationAnalysis();

array = ConvertStr2IntArray(arrWords);

PrintArray(array);

Console.WriteLine();