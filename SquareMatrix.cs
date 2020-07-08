using System;

namespace Matrix
{
    class SquareMatrix : Matrix
    {
        public SquareMatrix(int i) : base(i)
        {
        }

        public void Track(SquareMatrix a)
        {
            int track = 0;
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                track += a.matrix[i, i];
            }
            Console.WriteLine(track);
        }

        public double Determinant(SquareMatrix a)
        {
            double det = 0;
            int Rank = a.matrix.GetLength(0);
            if (Rank == 1)
                det = a.matrix[0, 0];
            if (Rank == 2)
                det = a.matrix[0, 0] * a.matrix[1, 1] - a.matrix[0, 1] * a.matrix[1, 0];
            if (Rank > 2)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    det += Math.Pow(-1, 0 + j) * a.matrix[0, j] * Determinant(GetMinor(a, 0, j));
                }
            }
            return det;
        }
        static SquareMatrix GetMinor(SquareMatrix matrix, int row, int column)
        {
            SquareMatrix buf = new SquareMatrix(matrix.matrix.GetLength(0) - 1);
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column)
                            buf.matrix[i - 1, j] = matrix.matrix[i, j];
                        if (i < row && j > column)
                            buf.matrix[i, j - 1] = matrix.matrix[i, j];
                        if (i > row && j > column)
                            buf.matrix[i - 1, j - 1] = matrix.matrix[i, j];
                        if (i < row && j < column)
                            buf.matrix[i, j] = matrix.matrix[i, j];
                    }
                }
            }
            return buf;
        }
        public SquareMatrix InverseMatrix(SquareMatrix a)
        {
            int detA = (int)Determinant(a);
            int AlgebDP = 0;
            SquareMatrix buf = new SquareMatrix(a.matrix.GetLength(0));
            SquareMatrix buf2 = new SquareMatrix(a.matrix.GetLength(0));
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    buf = GetMinor(a, i, j);
                    AlgebDP = (int)Determinant(buf);
                    if ((j + i) % 2 != 0)
                    {
                        AlgebDP = (int)Determinant(buf);
                        AlgebDP *= -1;
                    }
                    buf2.matrix[j, i] = AlgebDP / detA;
                }

            }
            return buf2;
        }

        public static SquareMatrix operator +(SquareMatrix a, SquareMatrix b)
        {
            SquareMatrix result = new SquareMatrix(a.matrix.GetLength(0));
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return result;
        }

        public static SquareMatrix operator -(SquareMatrix a, SquareMatrix b)
        {
            SquareMatrix result = new SquareMatrix(a.matrix.GetLength(0));
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }
            return result;
        }

        public static SquareMatrix operator *(SquareMatrix a, SquareMatrix b)
        {
            SquareMatrix result = new SquareMatrix(a.matrix.GetLength(0));
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
    }
}
