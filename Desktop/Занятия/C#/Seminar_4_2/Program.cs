// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int GetCounNum(int res)
{
   
    int count =1;
    int result = 1;

    while(res>=count)
    {
        
        result*=count;
        count++;

    }
    return result;

}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Произведение "+GetCounNum(num));
