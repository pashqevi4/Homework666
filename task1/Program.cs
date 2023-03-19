//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Enter First Number");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int B = Convert.ToInt32(Console.ReadLine());
int Smth(int A, int B)
{
    int x = A;
    int i = 1;
    while (i < B)
    {
        x = x * A;
        i++;
       
    }
    return x;
}

Console.WriteLine($"{Smth(A, B)}");