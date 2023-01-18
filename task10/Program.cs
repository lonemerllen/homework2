// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int num1,num2;
num1=a/100;
num2=a/10-num1*10;
Console.WriteLine($"{a} -> {num2}");