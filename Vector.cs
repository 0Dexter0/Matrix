using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Vector : Matrix
    {
        public Vector() : base(1, 3)
        {

        }

        public static Vector operator +(Vector a, Vector b)
        {
            Vector result = new Vector();
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return result;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            Vector result = new Vector();
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }
            return result;
        }

        public static Vector operator *(Vector a, Vector b)
        {
            Vector result = new Vector();
            result.matrix[0, 0] = a.matrix[0, 1] * b.matrix[0, 2] - a.matrix[0, 2] * b.matrix[0, 1];
            result.matrix[0, 1] = a.matrix[0, 2] * b.matrix[0, 0] - a.matrix[0, 0] * b.matrix[0, 2];
            result.matrix[0, 2] = a.matrix[0, 0] * b.matrix[0, 1] - a.matrix[0, 1] * b.matrix[0, 0];
            return result;
        }

        public int Scalar(Vector a, Vector b)
        {
            int result = 0;
            for(int i = 0; i < a.matrix.Length; i++)
            {
                result += a.matrix[0, i] * b.matrix[0, i];
            }
            return result;
        }

        public double Module(Vector a)
        {
            int result = 0;
            for (int i = 0; i < a.matrix.Length; i++)
            {
                result += (int)Math.Pow(a.matrix[0, i], 2);
            }
            return Math.Sqrt(result);
        }
    }
}
