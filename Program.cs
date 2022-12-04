double[,] GetRandomArray(int column, int rows)
{
    double[,] arr = new double[column, rows];
    Random a = new Random();
    for(int i = 0; i < column; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                arr[i,j] = a.Next();
            }
        }
    return arr;
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
        Console.WriteLine();
        }
}

//

double[,] arr = GetRandomArray(column:4,
                                rows: 3);

PrintArray(arr);