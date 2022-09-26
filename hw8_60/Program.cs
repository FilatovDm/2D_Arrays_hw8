/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int m = 3, n = 3, v = 3;

int[,,] Get3dRandomArray (int m, int n, int v)
{
    int randomItem = 0;
    int[,,] randomArray = new int[m, n, v];
    int[] checkNumberArray = new int[randomArray.Length];

    for (int i = 0; i < randomArray.Length;)
    {
        int j;
        randomItem = new Random().Next(10, 40); // интервал до 39 для лучшей проверки
        for (j = 0; j < i; j++)
        {
            if (randomItem == checkNumberArray[j]) break; // есть совпадение
        }
        
        if (j == i)
        {
            checkNumberArray[i] = randomItem;
            i++;
        }
        
    }

    int count = 0;
    for (int k = 0; k < randomArray.GetLength(0); k++)
    {
        for (int i = 0; i < randomArray.GetLength(1); i++)
        {
            for (int j = 0; j < randomArray.GetLength(2); j++)
            {
                randomArray[i, j, k] = checkNumberArray[count];
                count++;
            }
            
        }
    }
    return randomArray;
}

int[,,] random3dArray = Get3dRandomArray(m, n, v);

for (int k = 0; k < random3dArray.GetLength(0); k++)
    {
        for (int i = 0; i < random3dArray.GetLength(1); i++)
        {
            for (int j = 0; j < random3dArray.GetLength(2); j++)
            {
                Console.Write($"{random3dArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }

//P.S. Очень интересная задачка, пришлось помозговать :)
