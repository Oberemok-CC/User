// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность первой матрицы: ");
int[,] array1 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(1, 9);
        Console.Write(array1[i, j] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine("_______________");

Console.WriteLine("Введите размерность второй матрицы: ");
int[,] array2 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(1, 9);
        Console.Write(array2[i, j] + " ");

    }
    Console.WriteLine();
}
Console.WriteLine("_______________");

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножать");
}
else
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            Console.Write((array3[i, j] = sum) + " ");

        }
        Console.WriteLine();

    }
}
