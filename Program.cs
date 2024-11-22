namespace ConsoleApp1
{
    public class Matrix<T>
    {
        T[,] values;
        public Matrix() : this(3) { }
        public Matrix(int n) : this(n, n) { }
        public Matrix(int rows, int columns) 
        {
            if (rows < 1 || columns < 1)
            {
                throw new ArgumentException("The rows or colums were set to be less than 1");
            }
            values = new T[rows, columns];
        }
        public int Rows { get { return values.GetLength(0); } }
        public int Colums { get { return values.GetLength(1); } }
        public static Matrix<T> Add(Matrix<T> matrixA, Matrix<T> matrixB) 
        {
            Matrix<T> result = new Matrix<T>(matrixA.Rows, matrixA.Colums);
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Colums; j++)
                {
                    matrixA[i, j] += matrixB[i, j];
                }
            }
            return result;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
