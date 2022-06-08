// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

uint Acker(uint m, uint n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Acker(m - 1, 1);
    else
      return Acker(m - 1, Acker(m, n - 1));
}

Console.WriteLine(Acker(2,3));
Console.WriteLine(Acker(3,2));
