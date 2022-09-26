Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int s = (num % 100) / 10;
Console.WriteLine($"Вторая цифра в Вашем числе - > {s}");