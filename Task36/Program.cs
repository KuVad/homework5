// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[6];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int summa_odd = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    summa_odd += array[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {summa_odd}");
