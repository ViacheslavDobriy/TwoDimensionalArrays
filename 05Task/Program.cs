// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] FillArray()
{
    Random random = new Random();
    int[,] Array = new int[random.Next(3, 6), random.Next(3, 6)];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = random.Next(0, 11);
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
void FoundStuff(int[,] Array)
{
    Console.Write("Введите число, которое нужно найти: ");
    int UserNumber = Convert.ToInt32(Console.ReadLine());
    bool IsItHere = false;
    int howManyTimes = 0;
    Console.WriteLine();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] == UserNumber)
            {
                Console.WriteLine("Ваше число есть в {0}-ой строке в {1}-ом столбце", i + 1, j + 1);
                IsItHere = true;
                howManyTimes++;
            }
        }
    }
    if (!IsItHere) Console.WriteLine("Ваше число ни разу не встречается в данном двумерном массиве");
    else Console.WriteLine($"Ваше число встречается {howManyTimes}");
}
int[,] OurArray = FillArray();
ShowArray(OurArray);
FoundStuff(OurArray);