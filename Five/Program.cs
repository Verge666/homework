int [,]arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
int []sums = new int [3];
int sum;
int sumMin;
int index = 1;
for (int i = 0; i < arr.GetLength(0); i++)
{
    sum = 0;
    for (int j =0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j]; 
    }
    sums[i] = sum;
}
sumMin = sums [0];
for (int i = 0; i < arr.GetLength(0); i++)
{
    if (sums[i] < sumMin)
    {
        sumMin = sums[i];
        index = i + 1;
    }
}
Console.WriteLine(index + " строка");