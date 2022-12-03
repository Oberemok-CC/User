// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// // убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");

    }
    Console.WriteLine();
}

int[,] PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;

}
void ChangeRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int rowsCount = 0; rowsCount < array.GetLength(1) - 1; rowsCount++)
            {
                if (array[i, rowsCount] < array[i, rowsCount + 1])
                {
                    int temp = array[i, rowsCount + 1];
                    array[i, rowsCount + 1] = array[i, rowsCount];
                    array[i, rowsCount] = temp;
                }
            }
        }

    }

}

Console.WriteLine("____________");
ChangeRows(matrix);
PrintArray(matrix);
