// Задача 2. Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/* Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine("Максимальное число: " + a);
}
if (a<b)
{
    Console.WriteLine("Максимальное число: " + b);
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/* Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int e = Convert.ToInt32(Console.ReadLine());

// вариант решения 1

if (a>b && b>e)
{
    Console.WriteLine("Максимальное число: " + a);
}
if (b>a && b>e)
{
    Console.WriteLine("Максимальное число: " + b);
}
if (e>a && e>b)
{
    Console.WriteLine("Максимальное число: " + e);
}

*/ 

// вариант решения 2

/* int max = a;
if(a>max) max = a;
if(b>max) max = b;
if(e>max) max = e;

Console.WriteLine("Максимальное число: " + max);
*/

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

/* Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int div = a%2;

if (div == 0)
{
   Console.WriteLine("да"); 
}
else
{
   Console.WriteLine("нет"); 
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1; 
int m = 1;

while(i <= n)
{
    if(i % 2 == 0)
    {
        Console.Write(i + ",");
        m++;
    }
    if(m >= n)
    {
        break;
    }
    i++;
} 










