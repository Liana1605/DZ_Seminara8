// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(" " + arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void DecreasingString(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1) -1 ; count++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int buffer = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = buffer;
                }
            }
        }
    }
}

int columns = AddNumber("Введите количесвто столбцов: ");
int rows = AddNumber("Введите количесвто строк: ");
int[,] matrix = new int[columns, rows];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
DecreasingString(matrix);
Console.WriteLine();
PrintMatrix(matrix);
