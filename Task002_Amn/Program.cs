// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = i+j;
    return matrix;
}

Console.Write("Enter amount of matrix rows: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(m,n);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);