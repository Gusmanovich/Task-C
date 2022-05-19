//Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Ввидите диапазон возможных координат точек:   ");
int number18 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввидите номер четверти от 1 до 4:   ");
byte number18n = byte.Parse(Console.ReadLine()??"0"); 
//??"0" в функции Parse означает что присваиваится 0 если не введено значение пользователем

if (number18n == 1 || number18n == 2)
{
    Console.WriteLine($"Диапазон для возможных координат по X: от 0 до {number18}");
}
else if (number18n == 3 || number18n == 4)
{
    Console.WriteLine($"Диапазон для возможных координат по X: от {-number18} до 0");
}
if (number18n == 1 || number18n == 4)
{
    Console.WriteLine($"Диапазон для возможных координат по У: от 0 до {number18}");
}
else if (number18n == 2 || number18n == 3)
{
    Console.WriteLine($"Диапазон для возможных координат по У: от {-number18} до 0");
}
else Console.WriteLine("Количество четвертей не может превышать 4");