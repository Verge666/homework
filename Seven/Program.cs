Console.WriteLine("введите цифру, обозначающую день недели: ");
int n = int.Parse(Console.ReadLine());
if ((n > 0) && (n < 8))
{
    if ((n == 6) || (n == 7))
    {
        Console.WriteLine("это выходной день");
    }
    else
    {
        Console.WriteLine("это будний день");
    }
}
else 
{
    Console.WriteLine("число должнобыть от 1 до 7");
}