Console.WriteLine("Введите цифру обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (num < 1 || num > 7)
{
    Console.WriteLine("Это вообще не день недели");
}
else 
{
    Console.WriteLine("Это не выходной день");
}