// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("введите трехзначное число x ");
int x = Convert.ToInt32(Console.ReadLine());
if  ((x > 100)&&(x < 999)) 
{
    int x1 = x / 10;
    int x2 = x1 % 10;

  
    Console.WriteLine(x2);
    Console.WriteLine();
}
