Console.Clear();
Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
if (numA>numB)
{
Console.Write($"max = {numA}");
}
else if (numA == numB)
{
Console.Write("Числа равны");
}
else
{
Console.Write($"max = {numB}");
}