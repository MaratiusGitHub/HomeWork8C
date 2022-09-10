// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MinSumRows(int[,] massive)
{
    int[] SumString = new int[massive.GetLength(0)];

    for (int i = 0; i < massive.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            sum += massive[i, j];
            SumString[i] = sum;

        }
    }
    Console.WriteLine($"Сумма каждой строки = {string.Join(", ", SumString)}");


    int minSum = SumString[0];
    int indexMinSum = 0;
    for (int n = 0; n < SumString.Length; n++)
    {
        if (minSum > SumString[n])
        {
            minSum = SumString[n];
            indexMinSum = n;
        }
    }
        Console.WriteLine($"Номер строки с наименьшей суммой элементов = {indexMinSum}");
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = GetArray(rows, columns, 0, 10);
PrintArray(myArray);
Console.WriteLine();

MinSumRows(myArray);
