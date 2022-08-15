// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = (num % 100);
int num2 = (num / 1000);
int num3 = 0;
while (num1 > 0)
{
    int nu = num1 % 10;
     num1 = num1 / 10;
     num3 = num3 * 10;
     num3 = num3 + nu; 
}
if (num2 == num3)
{
    Console.WriteLine($"Введеное число {num} является полиндромом");
}
else 
{
    Console.WriteLine($"введеное число {num}, не является полиндромом");
}