﻿Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"число {num} является ЧЁТНЫМ");
}
else
{
    Console.WriteLine($"число {num} является НЕЧЁТНЫМ");
}