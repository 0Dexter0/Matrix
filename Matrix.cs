using System;

namespace Matrix
{
    class Matrix
    { 
        public int[,] matrix;
        static Random rnd = new Random();
        public Matrix(int i, int j)
        {
            matrix = new int[i, j];
        }
        public Matrix(int i)
        {
            matrix = new int[i, i];
        }


        public Matrix Random(Matrix matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    matrix.matrix[i, j] = rnd.Next(0, 10);
                }
            }
            return matrix;
        }

        public Matrix ManualInput(Matrix matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter elem [{i + 1},{j + 1}]");
                    matrix.matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }
            return matrix;
        }

        public void ShowMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    Console.Write(matrix.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))
            {
                Matrix result = new Matrix(a.matrix.GetLength(0), a.matrix.GetLength(1));
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                    }
                }
                return result;
            }
            else
                throw new Exception("Err");
        }


        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))
            {
                Matrix result = new Matrix(a.matrix.GetLength(0), a.matrix.GetLength(1));
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        result.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                    }
                }
                return result;
            }
            else
                throw new Exception("Err");
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(1) == b.matrix.GetLength(0))
            {
                Matrix result = new Matrix(a.matrix.GetLength(0), b.matrix.GetLength(1));
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < b.matrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.matrix.GetLength(0); k++)
                        {
                            result.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
                return result;
            }
            else
                throw new Exception("Err");
        }
    }
}
