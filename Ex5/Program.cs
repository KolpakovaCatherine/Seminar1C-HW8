/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int size = ReadInt("Введите размерность квадратного массива: ");
int[,] numbers = new int[size, size];
int count = 1;
int i = 0;
int j = 0;
while (count <= numbers.Length)
{
    numbers[i, j] = count++;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
}

WriteMatrix(numbers);

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + "  ");
            }
            else if (array[i, j] >= 10 && array[i, j] < 100)
            {
                Console.Write(array[i, j] + "  ");
            }
            else if (array[i, j] >= 100) 
            {
                Console.Write(array[i, j]+ " ");
            }
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
