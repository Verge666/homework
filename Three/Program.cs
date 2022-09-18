int [,]arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
double []avrg = new double[arr.GetLength(1)];
int sum;
for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            {
              sum += arr[i, j];  
            }
        avrg[j] = Math.Round((double) sum/arr.GetLength(0), 1);
        Console.Write(avrg[j] + "  ");    
    }