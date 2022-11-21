// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 

// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int num1 = new Random().Next(10,1000);
Console.WriteLine(num1);

if((num1%7==0)&&(num1%23==0))

    Console.WriteLine("ДА");

else

    Console.WriteLine("НЕТ");
