// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int EnterNumber(string message)                                                             // Метод получения числа от пользователя из консоли
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,,] CreateArrayWithTwoDigitElemets(int indexX, int indexY, int indexZ)               // Метод создания трехмерного массива и заполнения его неповторяющимися двузначными числами
{
    int[,,] matrix = new int[indexX, indexY, indexZ];
    int counter = 10;
    for (int x = 0; x < indexX; x++)
    {
        for (int y = 0; y < indexY; y++)
        {
            for (int z = 0; z < indexZ; z++)
            {
                matrix[x, y, z] = counter;
                counter++;
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] matrix)                                                               // Метод вывода трехмерного массива в консоль
{
    for (int z = 0; z < matrix.GetLength(2); z++)
    {
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                Console.Write(" " + matrix[x, y, z] + " (" + x + y + z + ")" + " ");
            }
            Console.WriteLine();
        }
    }
}


// Получить от пользователя размер трехмерного массива

int indexX = EnterNumber("Введите число ячеек по Х: ");
int indexY = EnterNumber("Введите число ячеек по Y: ");
int indexZ = EnterNumber("Введите число ячеек по Z: ");

// Создать трехмерный массив и заполнить его

int[,,] matrix = CreateArrayWithTwoDigitElemets(indexX, indexY, indexZ);

// Печать трехмерного массива в консоль

PrintArray(matrix);