Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int i = n;
while (i > 0)
{
    sum = sum + (i % 10);
    i = i/10;
}
Console.WriteLine("сумма цифр числа " + n + " равна: " + sum);