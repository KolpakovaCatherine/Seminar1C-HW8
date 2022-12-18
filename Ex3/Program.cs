/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rows1 = ReadInt("Введите количество строк для первой матрицы: ");
int columns1 = ReadInt("Введите количество столбцов для первой матрицы: ");
int rows2 = ReadInt("Введите количество строк для второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов для второй матрицы: ");
int[,] numbers1 = new int[rows1, columns1];
FillMatrixRandomNumbers(numbers1);
int[,] numbers2 = new int[rows2, columns2];
FillMatrixRandomNumbers(numbers2);
WriteMatrix(numbers1);
WriteMatrix(numbers2);

int temp = 0;
int[,] multiplicationNumbers = new int[rows1, columns2];

if (columns1 == rows2)
{
    for (int i = 0; i < multiplicationNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicationNumbers.GetLength(1); j++)
        {
            for (int k = 0; k < multiplicationNumbers.GetLength(1); k++)
            {
                temp = numbers1[i, k] * numbers2[k, j];
                multiplicationNumbers[i, j] += temp;
            }
        }
    }
    WriteMatrix(multiplicationNumbers);
}
else
{
    Console.WriteLine("Произведение матриц не существует, так как кол-во столбцов первой матрицы не равно кол-ву строк второй матрицы");
}

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
