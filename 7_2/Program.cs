// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// ​8 4 2 4
// 1 7 -> такого числа в массиве нет

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

void FindArray(int[,] massive)
{
    Console.WriteLine("Введите строку:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец:");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int temp = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        
        for (int j = 0; j < massive.GetLength(1); j++)
        {            
            if (i == rows && j == colums)
            {
                Console.WriteLine($"{massive[i, j]}");
                break;
            }
            
            if (rows > massive.GetLength(0) || colums > massive.GetLength(1))
            {
               temp = 1;
            }            
        }        
    }
    if (temp == 1) Console.WriteLine($"Такого элемента в массиве нет");    
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
FindArray(array);