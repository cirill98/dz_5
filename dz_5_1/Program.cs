// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] array = new int[10];
// int len = array.Length;
// int index = 0;
// int total = 0;
// 
// while (index < len)
// {
    // array[index] = new Random().Next(100, 1000);
    // Console.Write($"{array[index]}, ");
    // index++;
// }
// Console.WriteLine();
// for (int i = 0; i < (len + 1); i++)
// {
    // if (array[index] % 2 == 0)
    // {
        // total += 1;
    // }
// }
// Console.WriteLine(total);
// Выводил масив, но не получилось вывести количество четных элементов массива. Ошибка заключалась в том, что индекс выходил за предел диапазона массива.

void FullAray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next(100, 1000);
    }
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

int [] array = new int [10];

FullAray(array);
PrintArray(array);
int total = 0;
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        total += 1;

    }
}
Console.WriteLine(total);