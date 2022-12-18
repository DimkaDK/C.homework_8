// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortDescendingElementsInArray(int[,] matrix)                                            // Метод сортировки массива по убыванию элементов в строке
{                                                  
    Console.WriteLine("Исходный массив: ");
    PrintArray(matrix);
    int max;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            max = matrix[i, j];
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    max = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = max;
                }
            }
        }
    }
    Console.WriteLine("Отсортированный массив: ");
    PrintArray(matrix);
}

// Получить от пользователя кол-во строк и столбцов

int columns = EnterNumber("Введите число столбцов: ");
int rows = EnterNumber("Введите число строк: ");

// Создать двухмерный массив и зполнить его

int[,] matrix = CreateRandomArray(columns, rows, 0, 10);

// Отсортировать элементы массива в строчках по убыванию

SortDescendingElementsInArray(matrix);
