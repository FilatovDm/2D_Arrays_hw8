/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//P. S. Сделал задание полностью сам, понимаю, что коряво. До этого опыта в программировании никакого не было.
// Хотелось бы посмотреть, конечно, оптимальное решение задачи с разбором.
// Программа заполняет только квадратные массивы любой величины. На прямоугольные времени не хватает...

int[,] FillArrayInSpiral(int[,] array, int number)
{
    //int number = 1;
    int pos = 1;
    int coeff = number;
    // слева направо САМЫЙ ПЕРВЫЙ ПРОХОД:
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = number;
        number++;
    }   


    while (number < array.Length + coeff)
    {
        // сверху вниз:
        for (int j = pos; j <= array.GetLength(0) - pos ; j++)
        {
            array[j, array.GetLength(0) - pos] = number;
            number++;
        } 
        if (number > array.Length + coeff) break;

        // справа налево:   
        for (int j = array.GetLength(1) - 1 - pos; j >= pos - 1; j--)
        {
            array[array.GetLength(1) - pos, j] = number;
            number++;
        }
        if (number > array.Length + coeff) break;
        
        // снизу вверх:   
        for (int j = array.GetLength(0) - 1 - pos; j >= pos; j--)
        {
            array[j, pos - 1] = number;
            number++;
        }
        if (number > array.Length + coeff) break;
        
        // слева направо:   
        for (int j = pos; j <= array.GetLength(1) - 1 - pos; j++)
        {
            array[pos, j] = number;
            number++;
        }
        if (number > array.Length + coeff) break;

        pos++;
    }
    return array;
}

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 

Console.Write("С какого числа начать заполнение? Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int[,] array = new int[m, n];

int [,]arraySpiral = FillArrayInSpiral(array, number);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (arraySpiral[i, j] < 10) Console.Write($"0{arraySpiral[i, j]} ");
        else Console.Write($"{arraySpiral[i, j]} ");
    }
    Console.WriteLine();
}
