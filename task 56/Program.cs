/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int[,] matrix = new int[4, 4] {  { 1, 4, 7, 2 },
                                 { 5, 9, 2, 3 },
                                 { 8, 4, 2, 4 },
                                 { 5, 2, 6, 7 }};
int[] SumMatrixLine(int[,] matrix)
{
    int[] sum = new int[4];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum[j] = sum[j] + matrix[j, i];

        }
    }
    return sum;
}

int Line(int[] lineS)
{
    int max = 0;
    int numbLine = 0;
    for (int j = 0; j < lineS.Length; j++) //Находим наибольшее число
    {
        if (max < lineS[j])
        {
            max = lineS[j];
        }

    }
    for (int i = 0; i < lineS.Length; i++) //Находим наименьее число
    {
        if (max > lineS[i])
        {
            max = lineS[i];
            numbLine = i + 1;
        }

    }

    return numbLine;
}

Console.WriteLine("номер строки с наименьшей суммой элементов: " + Line(SumMatrixLine(matrix)) + " строка");



