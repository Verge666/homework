int [,]arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
int temp;
int indexMax;
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                indexMax = 0;
                for (int k = j + 1; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, k] > arr[i, j])
                            {
                                indexMax = k; 
                                temp = arr[i, j];
                                arr[i, j] = arr[i, indexMax];
                                arr[i, indexMax] = temp;    
                            }
                    }
                                Console.Write(arr[i, j] + " ");   
            }
        Console.WriteLine();     
    }