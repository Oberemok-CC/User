// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[8];

int[] Getarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
Getarray(arr);


int GetCounNum(int[] res)
{
    int count =0;
    for (int i = 0; i < res.Length; i++)
    {
        if(res[i]%2 == 0)
        count++;
    }
       return count;
}
int c = GetCounNum(arr);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(c);