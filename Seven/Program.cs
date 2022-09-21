int [,,]arr = new int[2, 2, 2];
int []temp = new int[8];
Random rnd = new Random();
temp[0] = rnd.Next(10, 100);
for (int l = 0; l < temp.GetLength(0);)
{
    bool flag = false;
    int m;
    int n = rnd.Next(10, 100);
    for (m = 0; m < l;)
    {
        if (temp[m] == n)
        {
            flag = true;
            break;
        }
        else
        {
            m++;
        }
    }
    if (flag == false)
    {
        temp[l] = n;
        l++;
    }
}
int counter = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            arr[i, j, k] = temp[counter];
            counter++;
            Console.Write(arr[i, j, k] + "(" + i +", " + j +", " + k +")  ");
        }
        Console.WriteLine();
    }
}

