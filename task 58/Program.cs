/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();

int[,] resultMatrix = new int[2, 2];

int[,] oneMatrix = new int[2, 2] {  { 2, 4 },
                                    { 3, 2 }};

int[,] twoMatrix = new int[2, 2] {  { 3, 4},
                                    { 3, 3 }};

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
void OutMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("" + matrix[i, j] + " ");
        }
    }
}
Console.Write("Произведение двух матриц:\n 2 4 | 3 4 \n 3 2 | 3 3 \n");
MultiplyMatrix(oneMatrix, twoMatrix, resultMatrix);
OutMatrix(resultMatrix);