// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];

void PrintArray3D(int[,,] matr3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray3D(int[,,] matr3D)
{
    int count = 10;
    for (int i = 0; i < matr3D.GetLength(0); i++)
    {
        for (int j = 0; j < matr3D.GetLength(1); j++)
        {
            for (int k = 0; k < matr3D.GetLength(2); k++)
            {
                matr3D[k, i, j] += count;
                count += 3;
            }
        }
    }
}


FillArray3D(array3D);
PrintArray3D(array3D);