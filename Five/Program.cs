Console.WriteLine("введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int result;
if ((n > 999) || (n < 100))
{
    Console.WriteLine("число не трехзначное, введите другое число");
}
else
{
    result = (n / 10) % 10;
    Console.WriteLine("вторая цифра числа " + n + " - " + result);
}
