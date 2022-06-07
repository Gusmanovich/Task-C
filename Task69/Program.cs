// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

double Pow(int value, int pow)
{
    if (pow == 0)
        return 1;
    if (pow > 0)
        return Pow(value, pow - 1) * value;
    return 1.0 / Pow(value, -pow);
}

Console.WriteLine(Pow(3,5));




//Второй вариант

int Number(int numberOne, int numberTwo)
{
    if (numberTwo==0)
    {
        return 1;
    }
    else
    {
         return numberOne*Number(numberOne,numberTwo-1);

    }
}
Console.WriteLine("Введите 2 числа: ");
int numberOne=Convert.ToInt32(Console.ReadLine());
int numberTwo=Convert.ToInt32(Console.ReadLine());
int result = Number(numberOne, numberTwo);
Console.WriteLine(result);