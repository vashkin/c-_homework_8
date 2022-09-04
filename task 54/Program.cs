﻿/*
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

int[,] matrix = new int[3, 4] {  { 1, 4, 7, 2 },
                                 { 5, 9, 2, 3 },
                                 { 8, 4, 2, 4 } };


int[,] SortMatrix(int[,] matrix)
{
    int[,] matrixSort = new int[3, 4];
    int A = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int o = 0; o < matrix.GetLength(1); o++)
            {
                if (matrixSort[j, o] < matrix[j, i])
                {
                    A = matrixSort[j, o];
                    matrixSort[j, o] = matrix[j, i];
                    matrix[j, i] = A;
                }
            }
        }
    }
    return matrixSort;
}
void OutMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" { " + matrix[i, j] + " } ");
        }
    }
}


OutMatrix(SortMatrix(matrix));