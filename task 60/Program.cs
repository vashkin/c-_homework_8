/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
int[,,] arr = new int[2, 2, 2];

void GenMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {

                matrix[i, j, k] = RndNoRepeat(matrix);
            }
        }
    }
}
GenMatrix(arr);


int RndNoRepeat(int[,,] matrix)
{
    Random rnd = new Random();
    int rn = rnd.Next(10, 100);
    int su = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j, k] == rn)
                {
                    su = 100;
                }
            }
        }
    }
    if (su == 100)
    {
        rn = RndNoRepeat(matrix);
        return rn;
    }
    else
    {
        return rn;
    }
}
void OutMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
        }
    }
}
OutMatrix(arr);