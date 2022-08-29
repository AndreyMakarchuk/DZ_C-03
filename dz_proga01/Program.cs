// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? str = Console.ReadLine();
int prov = 0;
if (str!.Length != 5)
{
    Console.WriteLine($"{str} -> не пятизначное число");
}
else
    for (int i = 0; i < str!.Length / 2; i++)

        if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
        {
            Console.WriteLine($"{str} -> нет, не палиндром");
            break;
        }
        else
            prov = 1;

if (prov == 1) Console.WriteLine($"{str} -> да, палиндромом");
