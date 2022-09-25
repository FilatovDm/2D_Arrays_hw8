/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int m = 3, n = 4;

int[,] FillRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}

int[,] randomArray = FillRandomArray(m, n);
int[,] sortRowsArray = randomArray;

Console.WriteLine("Заданный массив: ");
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        Console.Write(randomArray[i, j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Упорядоченный массив: ");
int tmp;
for (int i = 0; i < sortRowsArray.GetLength(0); i++)
{
    for (int j = 0; j < sortRowsArray.GetLength(1); j++)
    {
        for (int k = 0; k < sortRowsArray.GetLength(1); k++)
        {
            if (sortRowsArray[i, j] <= sortRowsArray[i, k]) continue;
            
            tmp = sortRowsArray[i, j];
            sortRowsArray[i, j] = sortRowsArray[i, k];
            sortRowsArray[i, k] = tmp;   
        }
    }   
}

for (int i = 0; i < sortRowsArray.GetLength(0); i++)
{
    for (int j = 0; j < sortRowsArray.GetLength(1); j++)
    {
        Console.Write(sortRowsArray[i, j] + " ");
    }
    Console.WriteLine();
}
