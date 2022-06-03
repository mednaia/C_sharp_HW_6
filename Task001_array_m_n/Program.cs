// Показать двумерный массив размером m×n заполненный вещественными числами
// Console.Write("Input the number of strings of array: ");
// int m = int.Parse(Console.ReadLine()??"0");
// Console.Write("Input the number of columns of array: ");
// int n = int.Parse(Console.ReadLine()??"0");
// double[,]array = new double [m,n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().NextDouble(); 
//         Console.Write($"{Math.Round(array[i, j],2)} ");
//     }
//     Console.WriteLine(); 
// }


void PrintMatrix(double[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{Math.Round(matrix[i,j],2)}.");
    Console.WriteLine();
    }
}
double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    var random = new Random();
    for(int i=0;i<m;i++)
        for(int j=0;j<n;j++)
            matrix[i,j] = random.NextDouble();
    return matrix;
}

Console.Write("Enter amount of matrix rows: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int n = int.Parse(Console.ReadLine() ?? "0");
double[,] matrix = CreateMatrix(m,n);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);

