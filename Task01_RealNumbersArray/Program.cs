// Показать двумерный массив размером m×n заполненный вещественными числами

int GetInt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FillArray(double[,] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(from, to) + random.NextDouble();
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int m = GetInt("Введите число строк массива: ");
int n = GetInt("Введите число столбцов: ");
double[,] realNumbersArray = new double[m, n];
FillArray(realNumbersArray, 0, 10);
PrintArray(realNumbersArray);
