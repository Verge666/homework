Console.WriteLine("введите длину массива: ");
int n = int.Parse(Console.ReadLine());
Random rnd = new Random();
double max;
double min;
double[] array = new double[n];
for (int i = 0; i < n; i++)
    {
        array[i] = rnd.NextDouble();
        Console.WriteLine(array[i]);
    }
min = array[0];
max = array[0];
for (int i = 0; i < n; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }    
    double result = max - min;
    Console.WriteLine("разница наибольшего и наименьшего элементов массива равна: " + result);