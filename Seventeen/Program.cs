Console.WriteLine("введите колличество чисел (M): ");
int n = int.Parse(Console.ReadLine());
int[] a = new int [n];
int counter = 0;
Console.WriteLine("введите " + n + " чисел");
for (int i = 0; i < n; i++)
    {
        a[i] = int.Parse(Console.ReadLine());
        if (a[i] > 0)
            {
                counter++;
            } 
    }
Console.WriteLine("было введено " + counter + " чисел больше ноля");