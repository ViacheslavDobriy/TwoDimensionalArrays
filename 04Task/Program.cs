// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
int[,] CreateArray()
{
    Random random = new Random();
    int[,] Array = new int[random.Next(1,11), random.Next(1,11)];
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
            if (i%2==0 && j%2==0) Array[i, j] = Array[i, j]*Array[i,j];
        }
    }
    return Array;
}

int[,] OurArray = CreateArray();
ShowArray(OurArray);
Console.WriteLine();
OurArray = ChangeArray(OurArray);
ShowArray(OurArray);