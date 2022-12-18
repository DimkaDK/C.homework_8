// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void CreateSnailMatrix(int columns, int rows)                                              // Метод создания двухмерного массива и заполнения его улиткой
{
    int[,] matrix = new int[rows, columns];
    int counter = 1;
    int i = 0;
    int j = 0;

    for (int k = 0; k < rows - 1; k++)
    {
        for (j = k; j < columns - k; j++)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = counter;
                counter++;
            }
        }
        j--;

        PrintArray(matrix);
        Console.WriteLine();


        for (i = k; i < rows - k; i++)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = counter;
                counter++;
            }
        }
        i--;
        rows = rows - k;
        PrintArray(matrix);
        Console.WriteLine();

        for (j = columns - 1; j > -1 + k; j--)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = counter;
                counter++;
            }
        }
        j++;
        PrintArray(matrix);
        Console.WriteLine();

        for (i = rows - 1; i > -1 + k; i--)
        {
            if (matrix[i, j] == 0)
            {
                matrix[i, j] = counter;
                counter++;
            }
        }
        i = i + 2;
        PrintArray(matrix);
        Console.WriteLine();
    }
    PrintArray(matrix);
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


// Получить от пользователя кол-во строк и столбцов для массива

int columns = EnterNumber("введите число столбцов матрицы -  ");
int rows = EnterNumber("введите число строк матрицы -  ");

// Создать двухмерный массив и заполнить его

CreateSnailMatrix(columns, rows);