// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int GetInt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FillArray(int[,] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(from, to);
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
    Console.WriteLine();
}
int[,] ReplaceElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}
int m = GetInt("Введите число строк массива: ");
int n = GetInt("Введите число столбцов массива: ");
int[,] numbers = new int[m, n];
FillArray(numbers, 2, 2);
PrintArray(numbers);
ReplaceElements(numbers);
PrintArray(numbers);
