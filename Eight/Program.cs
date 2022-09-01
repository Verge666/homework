Console.WriteLine("введите пятизначное число");
int n = int.Parse(Console.ReadLine());
int n1 = (n % 100000)/10000;
int n2 = (n % 10000)/1000;
int n4 = (n % 100)/10;
int n5 = n % 10;
Console.WriteLine(n1);
if ((n > 99999 ) || (n < 10000))
    {
        Console.WriteLine("введенное число не пятизначное");
    }
else
    {
    if ((n1 == n5) && (n2 == n4))
        {
            Console.WriteLine("число " + n + " является палиндромом");
        }
    else
        {
            Console.WriteLine("число " + n + " не является палиндромом");
        }
    }
