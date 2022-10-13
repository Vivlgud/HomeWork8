// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();

int row = 2, column = 2, depth = 2;

// Генератор случайных неповторяющихся чисел
int[] rnd = new int[row * column * depth];
int temp = 0;

for (int i = 0; i < rnd.Length; i++)
{
    rnd[i] = new Random().Next(10, 100);
    temp = rnd[i];
    if (i >= 1)
    {
        for (int j = 0; j < i; j++)
        {
            while (rnd[i] == rnd[j])
            {
                rnd[i] = new Random().Next(10, 100);
                j = 0;
                temp = rnd[i];
            }
            temp = rnd[i];
        }
    }
    //Console.WriteLine(rnd[i]);
}

// Заполнение трехмерного массива из одномерного
int[,,] array = new int[row, column, depth];
int count = 0;
// Вывод массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = rnd[count];
            count++;
            Console.Write($"{array[i, j, k]} [{i},{j},{k}]  ");
        }
        Console.WriteLine();
    }
}


