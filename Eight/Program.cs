int[,] arr = new int[4, 4];
int counter = 0;
for (int i = 0; i < 4; i++)
{
    arr[0, i] = counter;
    counter++;
}
for (int i = 1; i < 4; i++)
{
    arr[i, 3] = counter;
    counter++;
}
for (int i = 2; i >= 0; i--)
{
    arr[3, i] = counter;
    counter++;
}
for (int i = 2; i >= 1; i--)
{
    arr[i, 0] = counter;
    counter++;
}
for (int i = 1; i < 3; i++)
{
    arr[1, i] = counter;
    counter++;
}
for (int i = 2; i < 3; i++)
{
    arr[i, 2] = counter;
    counter++;
}
arr[2, 1] = counter;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[i, j] + "  ");
    }
    Console.WriteLine();
}