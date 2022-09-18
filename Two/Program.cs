Console.WriteLine("введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] arr = new int[n, m];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rnd.Next(0, 100);
                Console.Write(arr[i, j] + " ");
            }
        Console.WriteLine();
    }