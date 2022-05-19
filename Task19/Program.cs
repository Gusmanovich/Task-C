//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// int i = 25454; // нужна проверка ввода пятизначного числа
// int a = int.Parse(Convert.ToString(i)[0].ToString());
// int b = int.Parse(Convert.ToString(i)[1].ToString());
// int c = int.Parse(Convert.ToString(i)[2].ToString());
// int d = int.Parse(Convert.ToString(i)[3].ToString());
// int e = int.Parse(Convert.ToString(i)[4].ToString());

// if (a == e && b == d) Console.WriteLine("Yes");
// else Console.WriteLine("No");


int EnteringNdigitNum(int num) //анализ правильности ввода N-значного числа
{
    int t;
    do
    {
        Console.Write($"Введите {num}-значное число: ");
        t = int.Parse(Console.ReadLine() ?? "0");
    }
    while (t < Convert.ToInt32(Math.Pow(10, num - 1)) || t > (Convert.ToInt32(Math.Pow(10, num)) - 1));
    return t;
}


void palindrome(string s) // Не знаю в каком цикле проверять условие 31 строки, пока настроено лишь на проверку 5-значного числа  

{
if ((s[0] == s[4]) && (s[1] == s[3]))
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");
}



int n = 5;

int i = EnteringNdigitNum(n);

string str = i.ToString();

if (n == str.Length)
{
    palindrome(str);
}
else Console.WriteLine("Неверное вводное значение");  // Для вывода информации пользователю о неверной значости числа








// Console.WriteLine(Convert.ToInt32(Math.Pow(10, 4)));

// Console.WriteLine(Convert.ToInt32(Math.Pow(10, 5))-1);