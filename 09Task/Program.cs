// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
int[,] SortArray(int[,] Array)
{
    int extraVar = 0;
    int numberRows = 0;
    for(int i = 0; i<Array.GetLength(0);i++)
    {
        numberRows = 0;
        while(numberRows<Array.GetLength(1))
        {
        for(int j = 1; j<Array.GetLength(1);j++)
        {
            if(Array[i,j-1]<Array[i,j])
            {
                extraVar = Array[i,j];
                Array[i,j] = Array[i,j-1];
                Array[i,j-1] = extraVar;
            }
        }
        numberRows++;
        }
    }
    return Array;
}
int[,] randomArray = FillArray();
ShowArray(randomArray);
Console.WriteLine();
randomArray = SortArray(randomArray);
ShowArray(randomArray);