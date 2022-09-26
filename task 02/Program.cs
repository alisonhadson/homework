Console.WriteLine("введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write($"Большее число из пары {number1}");
}
else Console.Write($"Большее число из пары {number2}");