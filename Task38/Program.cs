// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[6];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() + new Random().Next(0, 1000), 3);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double minimum = 1000;
double maximum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minimum)
    {
        minimum = array[i];
    }
    if (array[i] > maximum)
    {
        maximum = array[i];
    }
}

double result = maximum - minimum;
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна " + result);