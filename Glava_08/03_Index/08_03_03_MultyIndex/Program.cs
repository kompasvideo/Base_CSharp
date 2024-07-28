Matrix matrix = new Matrix();
Console.WriteLine(matrix[0,0]);
matrix[0, 0] = 111;
Console.WriteLine(matrix[0,0]);

class Matrix
{
    int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 4 }, { 3, 4, 8 } };
    public int this[int i, int j]
    {
        get => numbers[i, j];
        set => numbers[i, j] = value;
    }
}
