// Написать программу, которая обменивает элементы первой строки и последней строки
int GetInt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void FillArray (int [,] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=random.Next(from, to);
        }
    }
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] ChangeFirstAndLastLines(int [,]array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0,i];
        array[0,i]=array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i]=temp;
    }
    return array;
}
int m=GetInt("Введите число строк массива: ");
int n=GetInt("Введите число столбцов массива: ");
int [,] numbers = new int [m,n];

FillArray(numbers, 0, 10);
PrintArray (numbers);
ChangeFirstAndLastLines(numbers);
PrintArray (numbers);
