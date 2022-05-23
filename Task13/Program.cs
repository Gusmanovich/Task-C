// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int GetThirdNumber(int inputNumber)
{
    int result = 0;
    while (inputNumber > 999) //Делится и забываются числа больше 999
    {
        inputNumber /= 10;
    }
    result = inputNumber % 10;
    return result;
}

Console.Write("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if (number > 99)
{
    int thirdNumber = GetThirdNumber(number);
    Console.WriteLine($"Третье число {thirdNumber}");
}
else
{
    Console.WriteLine("Третьей цифры нет");

}
