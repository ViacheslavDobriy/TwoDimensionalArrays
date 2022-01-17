// В двумерном массиве n×k заменить четные элементы на противоположные
void ShowArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int n, int k)
{
    int[,] Array = new int[n, k];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 11);
        }
    }
    return Array;
}
int[,] ChangeArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] % 2 == 0) Array[i, j] = -Array[i, j];
        }
    }
    return Array;
}
int n = new Random().Next(3, 6);
int k = new Random().Next(3, 6);
Console.WriteLine($"{n} {k}");
int[,] OurArray = FillArray(n, k);
ShowArray(OurArray);
OurArray = ChangeArray(OurArray);
Console.WriteLine();
ShowArray(OurArray);
