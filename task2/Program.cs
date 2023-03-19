//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Enter Your Number");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int Division(int A)
{
    while (A > 2)
    {
        sum = sum + (A % 10);
        A = A / 10;
    }
    return sum;
}
Console.WriteLine($"{Division(A)}");