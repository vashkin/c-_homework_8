/* 
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] matrix = new int[4, 4];

int count = 1;
int x = 0;
int y = 0;

void matix(int[,] matrix)
{
    matrix[x, y] = count;
    count++;
    if (x <= y + 1 && x + y < matrix.GetLength(1) - 1)
        y++;
    else if (x < y && x + y >= matrix.GetLength(0) - 1)
        x++;
    else if (x >= y && x + y > matrix.GetLength(1) - 1)
        y--;
    else
        x--;
    if (matrix[x, y] == 0) { matix(matrix); }
}

void outMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) { Console.Write("0"); }
            Console.Write("" + matrix[i, j] + " ");
        }
    }
}

matix(matrix);
outMatrix(matrix);