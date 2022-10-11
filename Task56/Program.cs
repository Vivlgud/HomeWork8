// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Clear();

    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] array=new int[rows,columns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j]=new Random().Next(min,max);
                }
        }
        return array;
    }

    void PrintArray(int[,] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

int[,] arr = FillArray(4, 4, 1, 10);
PrintArray(arr);


int summ, minSum = 0, numberRow = 1;
for (int i = 0; i < arr.GetLength(0); i++)
{
    summ = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        summ += arr[i, j];
    }
    if (i == 0) minSum = summ; 
    if (minSum > summ) {minSum = summ; numberRow = i + 1;}
}
Console.WriteLine($"Строка {numberRow} имеет наименьшую сумму элементов {minSum}");

// Проверка сколько строк могут иметь минимальную сумму элементов

for (int i = 0; i < arr.GetLength(0); i++)
{
    summ = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        summ += arr[i, j];
    }
    if (minSum == summ && numberRow-1!=i) 
    {
        numberRow = i + 1;
        Console.WriteLine($"Строка {numberRow} имеет наименьшую сумму элементов {minSum}");
    }
}
