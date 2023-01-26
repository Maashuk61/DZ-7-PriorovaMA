// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] GetRandomMatrix(int rows, int colums, int leftRange, int rightRenge)
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRenge +1);
        }
    }
    return matrix;
}

void Average(int[,] massive)
{
   for (int j = 0; j < massive.GetLength(1); j++)
    { 
        double res1 = 0; 
        for (int i = 0; i < massive.GetLength(0); i++)
            {
                res1 = res1 + massive[i,j]; 
            }
        res1 = res1/(massive.GetLength(0));
        Console.WriteLine($"{res1:f1}");        

    }
}

void PrintMatrix(int[,] matrix)
{  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMS, LEFT_RANGE, RIGHT_RANGE);

PrintMatrix(array);
Console.WriteLine();
Average(array);