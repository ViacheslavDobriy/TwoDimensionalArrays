// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

int[,] FillArray()
{
    Random random =new Random();
    int[,] Array = new int[random.Next(3,11),random.Next(3,11)];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 11);
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
double ArithmeticMean(int[,] Array, int Index)
{
    double result = 0;
    int j = 0;
    for(; j<Array.GetLength(0);j++)
    {
        result = result+Array[j,Index];
    }
    return result/j;
}
int[,] NewArray = FillArray();
ShowArray(NewArray);
for(int i= 0; i <NewArray.GetLength(1);i++)
{
    Console.WriteLine($"Среднее арифметическое {i+1}-го столбца - {ArithmeticMean(NewArray, i)}");
}