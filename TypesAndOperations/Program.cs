// See https://aka.ms/new-console-template for more information
int[] simpleArray = new int[] { 1, 9, 3, 6, 5};
Console.WriteLine("Length: " + simpleArray.Length);                       // количество всех элементов

Array.Sort(simpleArray);
//Array.Reverse(array);
    
foreach (var item in simpleArray)
{
    Console.Write($"{item} \t");
}
Console.WriteLine();

// -============================================= Двумерный массив =============================================-
/*
int[,] array = new int[4, 5];
Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLowerBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array.GetLowerBound(1));   // Нижний индекс столбцов

Console.WriteLine("=========");



int t = 1;
// Задание значений
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
    }
}

/*
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
*/

// -============================================= Трехмерный массив =============================================-

int[,,] array3D = new int[,,]
{
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    },
    {
        { 7, 8, 9 },
        { 10, 11, 12 }
    }
};

Console.WriteLine("Length: " + array3D.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов

for (int i = 0; i <= array3D.GetUpperBound(0); i++)
{
    Console.WriteLine($"-========= Level {i} ==========-");
    for (int j = 0; j <= array3D.GetUpperBound(1); j++)
    {
        for (int k = 0; k <= array3D.GetUpperBound(2); k++)
        {
            Console.Write($"{array3D[i, j, k]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"-============================-");
}

// -============================================= Многомерный (зубчатый) массив =============================================-
/*
int[][] numbers =
{
    new int[] { 1, 2 },
    new int[] { 1, 2, 3, 4, 5 },
    new int[] { 1, 2, 3 }
};
Console.WriteLine("Length: " + numbers.Length); // количество всех элементов
Console.WriteLine("Rank: " + numbers.Rank); // ранк массива
Console.WriteLine("GetLength(0): " + numbers.GetLength(0)); // количество строк
Console.WriteLine("GetUpperBound(0): " + numbers.GetUpperBound(0)); // количество строк
//Console.WriteLine("GetLength(1): " + numbers.GetLength(1));           // ошибка - нет столбцов
Console.WriteLine("=========");

foreach (int[] row in numbers)
{
    for (int i = 0; i < row.Length; i++)
    {
        //row[i] = new Random().Next(10);
    }
}

for (int i = 0; i <= numbers.GetUpperBound(0); i++)
{
    for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }

    Console.WriteLine();
}

foreach (int[] row in numbers)
{
    Console.WriteLine("Length: " + row.Length);
}
*/