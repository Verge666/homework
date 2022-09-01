Console.WriteLine("введите пятизначное число");
string n = Console.ReadLine();
if ((int.Parse(n) > 99999 ) || (int.Parse(n) < 10000))
    {
        Console.WriteLine("введенное число не пятизначное");
    }
else
    {
    if ((n[0] == n [4]) && (n[1] == n[3]))
        {
            Console.WriteLine("число " + n + " является палиндромом");
        }
    else
        {
            Console.WriteLine("число " + n + " не является палиндромом");
        }
    }
