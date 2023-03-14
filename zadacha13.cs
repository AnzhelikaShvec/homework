// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
 Console.WriteLine("введите число x ");
int x = Convert.ToInt32(Console.ReadLine());

if  ((x > 100)&&(x < 1000))

    int x1 = x / 100;
    int x2 = x1 % 10;
    Console.WriteLine("x2");
if (x > 999)
    while (x > 10000)
    {
        int x3 = x / 10;
        int x4 = x3 % 10;
    }
    if (x<100)
    Console.WriteLine("третьей цифры нет");
