Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText= Convert.ToString(num);
if (numText.Length > 2)
{
    Console.WriteLine($"Третья цифра - > {numText[2]}");
}
else
{
    Console.WriteLine("Третьего числа нет");
}