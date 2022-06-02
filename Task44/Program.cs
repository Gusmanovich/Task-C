// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int n)
{
    Console.Write($"Если N = {n} ->: ");
    int i = 0;
    int fib1 = 0;
    int fib2 = 1;
    Console.Write($" 0 1 ");
    while (i < n - 2)
    {
        int fibSum = fib1 + fib2;
        fib1 = fib2;
        fib2 = fibSum;
        i++;
        Console.Write($"{fib2} ");
    }
    Console.WriteLine();
    Console.WriteLine($"f({n}) = {fib2}");
}


Console.Write("Введите номер элемента ряда Фибоначчи: ");
int number = Convert.ToInt32(Console.ReadLine());

Fibonacci(number);


