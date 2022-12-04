double[,] GetRandomArray(int column, int rows)
{
    double[,] arr = new double[column, rows];
    Random a = new Random();
    for(int i = 0; i < column; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                arr[i,j] = a.Next();
                Console.Write($"{arr[i,j]} ");
            }
        Console.WriteLine();
        }
    return arr;
}

//

double[,] arr = GetRandomArray(column:4,
                                rows: 3);

