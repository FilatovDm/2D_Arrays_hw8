/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// Не стал рандомно заполнять массивы, а задал так, чтобы быстро проверить результат

int[,] firstMatrix = {
                      {1, 2, 2},
                      {3, 1, 1}
                     };
int[,] secondMatrix = {
                       {4, 2}, 
                       {3, 1},
                       {1, 5}
                      };

if (firstMatrix.GetLength(0) == secondMatrix.GetLength(1))
{

    int[,] GetMultiMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(0)];
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        return resultMatrix;
    }

    int[,] multiplicationMatrix = GetMultiMatrix(firstMatrix, secondMatrix);
    
    for (int i = 0; i < multiplicationMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicationMatrix.GetLength(1); j++)
        {
            Console.Write(multiplicationMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

else 
{
Console.WriteLine("Заданые матрицы не могут быть перемножены. " +
                  "Обе матрицы должны быть квадратными или количество" +
                  "строк первой должно совпадать с количеством строк второй");
}

