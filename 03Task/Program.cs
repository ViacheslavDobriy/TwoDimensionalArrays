// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] FillArray()
{
    Random random = new Random();
    int row = random.Next(2,11);
    int column = random.Next(2,11);
    int[,] Array = new int[row, column];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = i+j;
        }
    }
    return Array;
}
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
int[,] Array = FillArray();
ShowArray(Array);