// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = " ";
double n2 = Math.Pow(n, 3);
for (int i = 1; i < n; i++)
{
    double res = Math.Pow(i, 3);
    result = result + res + ", ";
    }
Console.Write($"{n} -> {result}{n2}");