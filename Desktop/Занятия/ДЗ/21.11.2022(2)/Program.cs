// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




int num = new Random().Next(10, 10000000);
Console.WriteLine(num);

if (num < 100)
    Console.Write("Третья цифра отсутствует ");
else
{
    while (num / 1000 > 0)
    {
        num = num / 10;
    }
    num = num%10;

    Console.Write(num);
}


