// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
double[] arr = new double [columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);
        Console.Write(matrix[i, j] + " ");
        arr[j]+=matrix[i,j];
    }
    Console.WriteLine();
}
for (int i = 0; i < arr.Length; i++)
{
    arr[i]=arr[i]/rows;
    arr[i] = Math.Round(arr[i], 2);
}
Console.WriteLine("___________________________");
Console.Write(String.Join(" ", arr));
Console.WriteLine();

