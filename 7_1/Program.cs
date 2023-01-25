// Задача 47: Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

double[,] GetRandomMatrix(int rows, int colums)
{
    double[,] matrix = new double[rows, colums];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * 10 + (random.NextDouble() * -10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f1}" + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMS = 4;


double[,] array = GetRandomMatrix(ROWS, COLUMS);
PrintMatrix(array);