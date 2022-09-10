// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationMatrix(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < A.GetLength(1); k++)
            {
                result[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return result;
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] ArrayA = GetArray(rows, columns, 0, 10);
PrintArray(ArrayA);
Console.WriteLine();

int[,] ArrayB = GetArray(columns, rows, 0, 10);
PrintArray(ArrayB);
Console.WriteLine();

PrintArray(GetMultiplicationMatrix(ArrayA, ArrayB));

