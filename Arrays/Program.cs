// See https://aka.ms/new-console-template for more information

int[,] array = new int[4, 5];
Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // количество строк
Console.WriteLine("GetLength(1): " + array.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array.GetUpperBound(1));   // количество столбцов
Console.WriteLine("GetLowerBound(0): " + array.GetLowerBound(0));   // количество столбцов
Console.WriteLine("GetLowerBound(1): " + array.GetLowerBound(1));   // количество столбцов
Console.WriteLine("=========");


int t = 1;
// Задание значений
/*
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = 1;
    }
}
*/

// Задание значений
for (int i = 0; i <= array.GetUpperBound(0); i++)
{
    for (int j = 0; j <= array.GetLowerBound(1); j++)
    {
        array[i, j] = t++;
    }
}

//int rows = array.GetUpperBound(0) + 1;    
int rows = array.GetLength(0);    
int columns = array.Length / rows;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

// Проход по всем элементам массива
foreach (int i in array)
{
    Console.WriteLine($"{i}");
}