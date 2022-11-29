// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] array = new int[8];

int[] Getarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
Getarray(array);

int count =0;
int GetCount(int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (res[i] > 0)
        {
          count++;  
        }
    }
    return count;
}

GetCount(array);

Console.Write(String.Join(" ", array));
Console.WriteLine();
Console.Write($"Кол-во элементов > 0: {count}");



