/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = 4, columns = 4;

int[,] FillRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int GetMinSumRow(int[,] array)
{
    int rowMinSumElem = 1;
    
    int[] sumElemRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElemRow[i] = sumElemRow[i] + array[i, j];
        }        
    }
    int minSum = sumElemRow[0];
    for (int i = 0; i < sumElemRow.Length; i++)
    {
        if (sumElemRow[i] < minSum) 
        {
            rowMinSumElem = i + 1;
            minSum = sumElemRow[i];
        }
    }
    Console.WriteLine("Сумма элементов: " + minSum);
    return rowMinSumElem;
}

int[,] randomArray = FillRandomArray(rows, columns);
int minSumRow = GetMinSumRow(randomArray);

Console.WriteLine("Заданный массив: ");
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        Console.Write(randomArray[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Наименьшая сумма элементов: {minSumRow} строка");