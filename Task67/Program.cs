// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int digitsSum(int number)
    {
        if(number==0) return 0;
        return number % 10 + digitsSum(number/10);
    }

Console.WriteLine(digitsSum(453));

void NaturalNumbersMN(int number, int summ=0)
{
    if (number == 0)
    {
        System.Console.WriteLine(summ);
    }
    if (number != 0)
    {
        summ = number % 10 + summ;
        number = number / 10;
        NaturalNumbersMN(number, summ);
    }
}
NaturalNumbersMN(45);
