/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
int[,] Matrix = new int[3, 4] {  { 1, 4, 7, 2 },
                                 { 5, 9, 2, 3 },
                                 { 8, 4, 2, 4 } };


int[,] sortMatrix(int[,] MatrixRealNumber)
{
    int[,] max = new int[3, 4];
    int A = 0;
    for (int j = 0; j < MatrixRealNumber.GetLength(0); j++)
    {
        for (int i = 0; i < MatrixRealNumber.GetLength(1); i++)
        {
            for (int o = 0; o < MatrixRealNumber.GetLength(1); o++)
            {
                if (max[j, o] < MatrixRealNumber[j, i])
                {
                    A = max[j, o];
                    max[j, o] = MatrixRealNumber[j, i];
                    MatrixRealNumber[j, i] = A;
                }
            }
        }
    }



    return max;
}
void outMatrix(int[,] MatrixRealNumber)
{
    for (int i = 0; i < MatrixRealNumber.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < MatrixRealNumber.GetLength(1); j++)
        {
            Console.Write(" { " + MatrixRealNumber[i, j] + " } ");
        }
    }
}


outMatrix(sortMatrix(Matrix));