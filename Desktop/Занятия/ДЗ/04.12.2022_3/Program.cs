// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и m.
// m = 2, m = 3 -> A(m,m) = 9
// m = 3, m = 2 -> A(m,m) = 29

// ![](https://www.bestprog.net/wp-content/uploads/2019/01/recursion_05r.jpg);

Console.Write("Введите число m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:  ");
int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
  if (m == 0) return n + 1;
  else
    if ((m != 0) && (n == 0)) return A(m - 1, 1);
    else
    return A(m - 1, A(m, n - 1));
}
Console.Write(A(m, n));