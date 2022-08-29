Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
int result;
int i = 1000;
int j = 1;
if (n < 100)
{
 Console.WriteLine("у числа нет третьей цифры");   
}
else
{
    while (n > i)
        {
            i*=10;
            j*=10;
        }
    result = (n / j) % 10;
    Console.WriteLine("третья цифра числа " + n + " - " + result);    
}