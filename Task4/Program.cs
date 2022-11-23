Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"Все четные числа от 1 до {N}: ");
do
{
    if (i%2==0)
    {
    Console.Write($"{i}, ");
    }
    i++;
} while (i <= N);


