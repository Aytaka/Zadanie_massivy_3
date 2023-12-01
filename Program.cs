// Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100)+ Math.Round(new Random().NextDouble(),2); 
Console.WriteLine(string.Join(", ", array));

double max = 0;
double min = 1000;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>=max) {
        max= array[i];
    }
    if (array[i]<=min) {
        min= array[i];
    }
}

Console.WriteLine($"{max-min}");
