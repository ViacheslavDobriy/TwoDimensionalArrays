// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] FillArray()
{
    Random random = new Random();
    int rowAndColumn = random.Next(2,11);
    int[,] Array = new int[rowAndColumn,rowAndColumn];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = random.Next(0,31);
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
int[] FoundRow(int[,] Array)
{
    int min = Array[0,0];
    int importantRow = 0;
    for(int i = 0; i<Array.GetLength(0);i++)
    {
        for(int j = 0; j<Array.GetLength(1);j++)
        {
            if(Array[i,j]<min)
            {
                min = Array[i,j];
                importantRow = i;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент массива - {min}");
    Console.Write($"Поэтому на экране {importantRow+1} ряд массива: ");
    int[] importantArray = new int[Array.GetLength(1)];
    for(int i = 0; i<importantArray.Length; i++)
    {
        importantArray[i] = Array[importantRow,i];
    }
    return importantArray;
}
void ShowRow(int[] Array)
{
    for(int i = 0; i< Array.Length; i++)
        Console.Write($"{Array[i]} ");
    Console.WriteLine();
}
int[,] randomArray = FillArray();
ShowArray(randomArray);
int[] RowMin = FoundRow(randomArray);
ShowRow(RowMin);
