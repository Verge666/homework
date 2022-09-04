int[] a = new int[8];
Console.WriteLine("введите значения элементов массива (8): ");
for (int i = 0; i < 8; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 8; i++)
{
   Console.Write(a[i] + " ");
}
