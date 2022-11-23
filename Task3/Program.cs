
Console.Clear();
Console.WriteLine("Введите число");
int numA = int.Parse(Console.ReadLine());
if (numA%2==0)
{
Console.Write($"Число {numA} является четным");
}
else
{
Console.Write($"Число {numA} является нечетным");    
}