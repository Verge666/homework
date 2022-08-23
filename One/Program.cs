Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB) 
{
    Console.WriteLine( numberA + " больше " + numberB);
}
else if (numberA < numberB)
{
    Console.WriteLine(numberB + " больше " + numberA);
}
else
{
 Console.WriteLine(numberB + " равно " + numberA);   
}
