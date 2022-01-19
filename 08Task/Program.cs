// Написать программу, которая обменивает элементы первой строки и последней строки

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
int[,] ChangeFirstAndLastRows(int[,] Array)
{
    int[] extraRow = new int[Array.GetLength(1)];
    int rows = Array.GetLength(0);
    for(int i=0; i<Array.GetLength(1);i++)
    {
        extraRow[i] = Array[0,i];
        Array[0,i] = Array[rows-1,i];
        Array[rows-1,i] = extraRow[i];
    }
    return Array;
}
int[,] RandomArray = FillArray();
ShowArray(RandomArray);
Console.WriteLine("Количество рядов - {0}; Количество столбцов - {1}",RandomArray.GetLength(0),RandomArray.GetLength(1));
RandomArray= ChangeFirstAndLastRows(RandomArray);
ShowArray(RandomArray);