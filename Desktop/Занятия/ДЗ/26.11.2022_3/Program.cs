// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

float[] arr = new float[8];

float[] Getarray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10000, 10000);
        array[i] = array[i]/100;
    }
    return array;
}
Getarray(arr);


float Getdif(float[] arr)
{
    float dif = 0;
    float max = arr[0];
    float min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
        dif = max - min;
     
    }
    Console.WriteLine($"Разница между {max} - {min} = {dif}");

    return dif;

}

float dif = Getdif(arr);
Console.WriteLine(String.Join(" ", arr));

