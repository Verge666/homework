int [,]matrixA = {{2, 4}, {3, 2}};
int [,]matrixB = {{3, 4}, {3, 3}};
int [,]matrixAB = new int [2, 2];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        matrixAB[i, j] = matrixA[i, 0] * matrixB[0, j] + matrixA[i, 1] * matrixB[1, j];
        Console.Write(matrixAB[i, j] + " ");
    }
    Console.WriteLine();
}