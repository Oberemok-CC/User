// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int minVal = Int32.MaxValue;

Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
int[] arr = new int[rows];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(2, 14);
        Console.Write(matrix[i, j] + " ");
        arr[i] += matrix[i, j];

    }
    Console.WriteLine();
}

int ChangeArray(int[] arr)
{
    int minRow = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minVal)
        {
            minVal = arr[i];
            minRow = i;
        }
        
    }
 return minRow +1;
}
Console.WriteLine("____________");
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine("____________");
Console.WriteLine($"Строка с наименьшей суммой элементов: {ChangeArray(arr)} строка");