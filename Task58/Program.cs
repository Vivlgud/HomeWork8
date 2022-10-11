// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] arrA = FillArray(3, 2, 1, 10);
PrintArray(arrA);
int[,] arrB = FillArray(2, 4, 1, 10);
PrintArray(arrB);

int[,] arrC=new int[arrA.GetLength(0),arrB.GetLength(1)];
int sum;
if (arrA.GetLength(1)==arrB.GetLength(0))
{
    for (int i = 0; i < arrA.GetLength(0); i++)
        {
            for (int j = 0; j < arrB.GetLength(1); j++)
            {
                sum=0;
                for (int k = 0; k < arrA.GetLength(1); k++)
                {
                  sum+=arrA[i,k]*arrB[k,j];  
                }
                arrC[i,j]=sum;
            }
        }
}
else Console.WriteLine("Перемножить матрицы невозможно");
Console.WriteLine("Произведение матриц равно ");
PrintArray(arrC);