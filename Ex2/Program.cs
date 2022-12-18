/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
int SumOfRow = 0;
int FindRow = 0;
int MinSumOfRow = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        SumOfRow += numbers[i, j];
    }
    Console.WriteLine($"Сумма элементов {i + 1}-ой строки = {SumOfRow}");
    if (i == 0)
    {
        MinSumOfRow = SumOfRow;
        FindRow = i + 1;
    }
    else
    {
        if (SumOfRow <= MinSumOfRow)
        {
            MinSumOfRow = SumOfRow;
            FindRow = i + 1;
        }
    }
    SumOfRow = 0;
}

Console.WriteLine($"Минимальная сумма элементов {MinSumOfRow} находится в {FindRow} строке массива");


void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
