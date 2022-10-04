int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int Func_1(int m, int n)
{
    if (m < n)
    {
        Console.WriteLine(m);
        return Func_1(m + 1, n);
    }
    else
    {
        Console.WriteLine(n);
        return 0;
    }

}
Func_1(m, n);
