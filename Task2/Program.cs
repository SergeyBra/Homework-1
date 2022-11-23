
Console.Clear();
Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numC= int.Parse(Console.ReadLine());
if (numA>numB) 
{
    if (numA>numC)
    {
     Console.Write($"max = {numA}");
    }
    else 
    {
    Console.Write($"max = {numC}");
    }
}
else
{
    if (numB>numC)
    {
     Console.Write($"max = {numB}");
    }
    else 
    {
    Console.Write($"max = {numC}");
    }
}