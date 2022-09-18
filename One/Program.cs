int [,]arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
Console.WriteLine("введите номер строки");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = int.Parse(Console.ReadLine());
if ((n > 3) || (n < 0) || (m > 4) || (m < 0))
    {
        Console.WriteLine("элемента с таким порядковым номером не существует");
    }
else
    {
        Console.WriteLine(arr[n, m]);
    }