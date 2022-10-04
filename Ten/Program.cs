int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int Func_1(int m, int n)
{
    if (m < n + 1)
    {
        return m + Func_1(m + 1, n);
    }
    else
    {
        return 0;
    }
}
Console.WriteLine(Func_1 (m, n));