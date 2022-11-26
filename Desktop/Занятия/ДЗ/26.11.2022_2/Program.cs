// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[8];

int[] Getarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}
Getarray(arr);


int GetSum(int[] res)
{
    int sum =0;
    for (int i = 1; i < res.Length; i = i +2)
    {
        sum+=res[i];
    }    
       return sum;
}
int c = GetSum(arr);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(c);
