// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
// Не получилось, сделать, чтоб вещественные числа на выходе не были такими длинными, как "73,81515532332479". 
void FullAray (double [] arr)
{
    int length = arr.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        arr [i] = rand.Next(-100, 100) + rand.NextDouble();
    }
}
void PrintArray (double [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}


double [] array = new double [5];

FullAray(array);
PrintArray(array);

int length = array.Length;
double max = array[0];
double min = array[0];


for (int i = 0; i < length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"max {max}");
Console.WriteLine($"min {min}");
Console.WriteLine($"Разница между максимальным и минимальным значанием =  {max - min}");