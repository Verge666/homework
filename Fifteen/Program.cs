Console.WriteLine("введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
Random rnd = new Random();
for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next();
        Console.WriteLine(array[i]);
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
Console.WriteLine("сумма нечетных элементов массива: " + sum);