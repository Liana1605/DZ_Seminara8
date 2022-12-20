// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CompositionTwoMatrix(int[,]first, int [,] second, int [,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            product[i, j] = sum; 

        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("   " + arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
        }
    }
}

int AddNumber(string meseg)
{
    Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int columsFirstMatrix = AddNumber("Введите количество столбцов первой матрицы: ");
int rowsFirstMatrix = AddNumber("Введите количество линий первой матрицы: ");
int columsSecondMatrix = AddNumber("Введите количество столбцов второй матрицы: ");
int rowsSecondMatrix = AddNumber("Введите количество линий второй матрицы: ");
if (columsFirstMatrix == rowsSecondMatrix)
{
    Console.WriteLine();
    int[,] firstMatrix = new int[columsFirstMatrix, rowsFirstMatrix];
    Console.WriteLine("Первая матрица: ");
    int[,] secondMatrix = new int[columsSecondMatrix, rowsSecondMatrix];
    FillMatrixRandomNumbers(firstMatrix);
    FillMatrixRandomNumbers(secondMatrix);
    PrintMatrix(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(secondMatrix);
    int [,] CompositionMatrix = new int [columsFirstMatrix, rowsSecondMatrix];
    CompositionTwoMatrix(firstMatrix, secondMatrix, CompositionMatrix);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц: ");
    PrintMatrix(CompositionMatrix);
}
else
    Console.WriteLine("Матрицы нельзя перемножить!!!");
