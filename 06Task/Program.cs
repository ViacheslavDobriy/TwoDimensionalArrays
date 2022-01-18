// В матрице чисел найти сумму элементов главной диагонали

int[,] FillArray()
{
    Random random =new Random();
    int[,] Array = new int[random.Next(2,10), random.Next(2,10)];
    Console.WriteLine($"Рядов - {Array.GetLength(0)}; Столбцов - {Array.GetLength(1)}");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-20, 21);
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
int SumMainDiagonal(int[,] Array)
{
    int Sum = 0;
    int i =0;
    int j =0;
    bool Stop = false;
    for(i =0; i< Array.GetLength(0); i++)
    {
        Stop = false;
        for(j =0 ; j<Array.GetLength(1) && Stop==false;j++)
        {
            if(i==j)
            {
                Sum = Sum +Array[i,j];
                Stop=true;
            }
        }
    }
    return Sum;
}
int[,] NewArray = FillArray();
ShowArray(NewArray);
Console.WriteLine($"Сумма элементов главной диагонали - {SumMainDiagonal(NewArray)}");