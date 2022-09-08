Console.Write("введите длину массива:  ");
int n = int.Parse(Console.ReadLine());
int[] array = new int [n];
int counter = 0;
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(100, 999);
    Console.WriteLine(array[i]);
    if (array[i] % 2 == 0)
    {
        counter += 1;
    }
}
Console.WriteLine("четных чисел в массиве: " + counter);