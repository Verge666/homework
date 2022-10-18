Console.WriteLine("введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int counter = 0;
string [] arr = new string[n];
Console.WriteLine("заполните массив ");
for (int i = 0; i < n; i++)
{
arr[i] = Console.ReadLine();
if (arr[i].Length < 4)
{
counter++;
}
}
Console.WriteLine("новый массив: ");
string [] arr2 = new string [counter];
counter = 0;
for (int i = 0; i < n; i++)
{
if (arr[i].Length < 4)
{
arr2[counter] = arr[i];
Console.Write(arr2[counter] + " ");
counter++;
}
}

