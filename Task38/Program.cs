// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) 
    array[i] = Convert.ToDouble(new Random().Next(1,10))/Convert.ToDouble(new Random().Next(1,10));
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}   ");
    Console.WriteLine();
}

double Min(double[] array)
{
    double min = array[0];
    int i =1;
    while (i < array.Length)
    {
        if (array[i] < min)  min = array[i];
        i++;
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    int i =1;
    while (i < array.Length)
    {
        if (array[i] > max)  max = array[i];
        i++;
    }
    return max;
}
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt16(Console.ReadLine());

double[] numbers = new double[n];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Минимальный элемент массива равен {Min(numbers)}");
Console.WriteLine($"Максимальный элемент массива равен {Max(numbers)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Max(numbers)-Min(numbers)}");
