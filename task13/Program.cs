// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int count = 0;
int ost=0;
Console.Write(a);
if (a>=100)
{
    while (count < 2)
    {
        a = a / 10;
        count++;
    }
ost=a%10;
Console.WriteLine($" -> {ost}");
}
else{
    Console.WriteLine($"{a} -> третьей цифры нет");
}