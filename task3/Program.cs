// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(1, 30);
        index++;
    }
}

void PrintArray(int[] array2)
{
    int quantity = array2.Length;
    int position = 0;
    while (position < quantity)
    {
        Console.Write($"{array2[position]}, ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
