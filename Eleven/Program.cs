int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int Func_ak(int m, int n)
{
if (m == 0)
    {
        return n + 1;
    }
else if (m > 0 && n ==0)
    {
        return Func_ak (m -1, 1);
    }    
else if (m > 0 && n > 0)
    {
        return Func_ak (m - 1, Func_ak(m, n-1));
    }  
else 
    {
        return 0;
    }          
}
Console.WriteLine(Func_ak(m, n));