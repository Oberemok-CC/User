// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int num = 2;
    if (N %2 == 0)  
     { while (num < N)
       { 
       Console.Write(num + ", "); 
       num = num +2; 
       }

    Console.Write(N + ". ");
     }
    else
    {  while (num < N-1)
        {
        Console.Write(num + ", "); 
        num = num +2; 
        }
        Console.Write(N-1 + ". ");
    }
    

