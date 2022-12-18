// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindRowWithLeastSumInArray(int[,] matrix)                                            // Метод поиска строки с наименьшей суммой элементов в массиве
{
    Console.WriteLine("В массиве: ");
    PrintArray(matrix);
    int sum = 0;
    int sumMin = 0;
    int indexMin = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumMin += matrix[0, j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sumMin > sum)
        {
            sumMin = sum;
            indexMin = i;
        }
        sum = 0;
    }
    Console.WriteLine($"строкой с наименьшей суммой элементов являетя: {indexMin + 1} строка");
}

// Получить от пользователя кол-во строк и столбцов

int columnsRows = EnterNumber("Введите число строк и столбцов: ");

// Создать двухмерный массив и зполнить его

int[,] matrix = CreateRandomArray(columnsRows, columnsRows, 0, 10);

// Находим строку с наименьшей суммой элементов

FindRowWithLeastSumInArray(matrix);