// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
int count = 1;
if (b < 1)
{
    Console.WriteLine("Ошибка ввода. Указанное число не является натуральным");
}
while (count <= b)
{
    result = result * a;
    count++;
}
Console.WriteLine(result);