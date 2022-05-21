// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int number = new Random().Next(10, 10000);
// Console.WriteLine(number);
int number = 645;
string str = number.ToString();
//int sot = (number/100) % 10;
if (sot == 0) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine("Третья цифра - " + sot);