/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int page = ReadInt("Введите количество страниц: ");
int[,,] numbers = new int[rows, columns, page];

Fill3DMatrixRandomNonrepetitiveNumbers(numbers);
Write3DMatrixWithIndex(numbers);


void Fill3DMatrixRandomNonrepetitiveNumbers(int[,,] array)
{
    // Первый способ: создание одновмерного массива с проверкой на повторяемость при заполнении массива.
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(10, 99);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 99);
                    j = 0;
                }
            }
        }
    }

    /* Второй способ: создание одновмерного массива от 1 до 99, его перетасовка. 
    int[] tempArray = new int[90];
    for (int i = 0, j = 9; i < tempArray.Length; i++, j++)
    {
        tempArray[i] = j + 1;
    }

    for (int i = 0; i < tempArray.Length; i++)
    {
        int TempNumber = tempArray[i];
        int TempIndex = new Random().Next(0, 90);
        tempArray[i] = tempArray[TempIndex];
        tempArray[TempIndex] = TempNumber;
    }
    */

    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = tempArray[count];
                count++;
            }
        }
    }
}

void Write3DMatrixWithIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({j},{k},{i})  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
