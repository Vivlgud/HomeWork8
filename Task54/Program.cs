// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    }

int[,] arr=FillArray(5,4,1,10);
PrintArray(arr);
Console.WriteLine();
int temp;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int k = 0; k < arr.GetLength(1)-1; k++)
    {
        for (int j = 0; j < arr.GetLength(1)-1-k; j++)
        {
            if (arr[i,j]<arr[i,j+1])
            {
                temp=arr[i,j];
                arr[i,j]=arr[i,j+1];
                arr[i,j+1]=temp;
            }
        }
    }
}

PrintArray(arr);