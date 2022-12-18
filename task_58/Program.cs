// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int columns, int rows, int leftRange, int rightRange)               // Метод создания двухмерного массива и заполнения его случайными числами
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)                                                               // Метод вывода двухмерного массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" " + matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplicationOfMatrixs(int[,] firstMatrix, int[,] secondMatrix)                                            // Метод поиска произведения двух матриц
{
    Console.WriteLine("Первая матрица: ");
    PrintArray(firstMatrix);
    Console.WriteLine("Вторая матрица: ");
    PrintArray(secondMatrix);

    int[,] multiplicationMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    // Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А (firstMatrix) совпадает с числом строк матрицы В (secondMatrix)
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    multiplicationMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        Console.WriteLine("Произведение матриц: ");
        PrintArray(multiplicationMatrix);
    }
    else
    {
        Console.WriteLine("Данные матрицы перемножить нельзя.");
        Console.WriteLine("Произведение двух матриц АВ имеет смысл только в том случае,");
        Console.WriteLine("когда число столбцов матрицы А совпадает с числом строк матрицы В ");
    }
}

Console.WriteLine("Для перемножения двух матриц заполненых случайными числами от 0 до 9, введите:");
// Получить от пользователя кол-во строк и столбцов для первой матрицы

int columns1 = EnterNumber("введите число столбцов первой матрицы -  ");
int rows1 = EnterNumber("введите число строк первой матрицы -  ");

// Создать двухмерный массив для первой матрицы и заполнить его

int[,] firstMatrix = CreateRandomArray(columns1, rows1, 0, 10);

// Получить от пользователя кол-во строк и столбцов для второй матрицы

int columns2 = EnterNumber("введите число столбцов второй матрицы -  ");
int rows2 = EnterNumber("введите число строк второй матрицы -  ");

// Создать двухмерный массив для второй матрицы и заполнить его

int[,] secondMatrix = CreateRandomArray(columns2, rows2, 0, 10);

// Находим произведение двух матриц

MultiplicationOfMatrixs(firstMatrix, secondMatrix);