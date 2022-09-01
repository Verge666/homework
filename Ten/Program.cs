Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }