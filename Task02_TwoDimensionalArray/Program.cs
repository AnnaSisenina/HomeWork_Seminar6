// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int GetInt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FillArraySumIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
}
void PrintArray(int[,] array)
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
int n = GetInt("Введите число столбцов массива: ");
int[,] numbers = new int[m, n];
FillArraySumIndex(numbers);
PrintArray(numbers);