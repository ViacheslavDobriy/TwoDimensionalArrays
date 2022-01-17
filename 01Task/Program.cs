// Показать двумерный массив размером m×n заполненный целыми числами

int m = new Random().Next(2,6);
int n = new Random().Next(2,6);
Console.WriteLine($"{m} {n}");
int[,] Array = new int[m,n];
for(int i = 0; i<Array.GetLength(0);i++)
{
    for(int j = 0; j<Array.GetLength(1); j++)
    {
        Array[i,j] = new Random().Next(0,11);
        Console.Write($"{Array[i,j]} ");
    }
    Console.WriteLine();
}