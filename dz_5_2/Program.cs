// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int [] array = new int [5];

FullAray(array);
PrintArray(array);
int total = 0;
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        total += array[i];

    }
}
Console.WriteLine(total);

// использовал тотже код, что и из предыдущей задачи, но в total запичал сумму нечетных элементов массива