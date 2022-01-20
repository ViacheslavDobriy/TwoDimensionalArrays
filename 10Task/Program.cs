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
int[] FoundRow(int[,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            sumRow[i] += matrix[i,j];
        }
    }
    return sumRow;
} 
(int,int) LessValue(int[] Line)
{
    int min = Line[0];
    int index = 0;
    for(int i = 1; i < Line.Length; i++)
    {
        if(min>Line[i])
        {
            min = Line[i];
            index = i;
        }
    }
    return (min,index);
}
int[,] randomArray = FillArray();
ShowArray(randomArray);
Console.WriteLine();
int[] RowSum = FoundRow(randomArray);
Console.WriteLine("Строка под номером {0} обладает наименьшей суммой элементов. Сумма равна {1}", LessValue(RowSum).Item2+1, LessValue(RowSum).Item1 );
