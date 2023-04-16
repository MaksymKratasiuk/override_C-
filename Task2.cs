using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_C_
{
    internal class Task2
    {
        private int[,] data;
        private int numRows;
        private int numCols;

        public int this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        public Task2(int rows, int cols)
        {
            numRows = rows;
            numCols = cols;
            data = new int[numRows, numCols];
        }

        public void FillMatrix()
        {
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write("Element[{0},{1}]: ", i, j);
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void DisplayMatrix()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write("{0}\t", data[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int Max()
        {
            int max = data[0, 0];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }
            return max;
        }

        public int Min()
        {
            int min = data[0, 0];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }

        public static Task2 operator +(Task2 matrix1, Task2 matrix2)
        {
            if (matrix1.numRows != matrix2.numRows || matrix1.numCols != matrix2.numCols)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            Task2 result = new Task2(matrix1.numRows, matrix1.numCols);

            for (int i = 0; i < matrix1.numRows; i++)
            {
                for (int j = 0; j < matrix1.numCols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Task2 operator -(Task2 a, Task2 b)
        {
            if (a.numRows != b.numRows || a.numCols != b.numCols)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions.");
            }

            Task2 result = new Task2(a.numRows, a.numCols);

            for (int i = 0; i < result.numRows; i++)
            {
                for (int j = 0; j < result.numCols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }

        public static Task2 operator *(Task2 matrix1, Task2 matrix2)
        {
            if (matrix1.numCols != matrix2.numRows)
            {
                throw new ArgumentException("Invalid matrix dimensions.");
            }

            Task2 result = new Task2(matrix1.numRows, matrix2.numCols);

            for (int i = 0; i < matrix1.numRows; i++)
            {
                for (int j = 0; j < matrix2.numCols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.numCols; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }



        public void Assign(int[,] newData)
        {
            if (numRows != newData.GetLength(0) || numCols != newData.GetLength(1))
            {
                throw new ArgumentException("Invalid matrix dimensions.");
            }

            data = newData;
        }


        public override bool Equals(object obj)
        {
            if (!(obj is Task2))
            {
                return false;
            }

            Task2 other = (Task2)obj;

            if (numRows != other.numRows || numCols != other.numCols)
            {
                return false;
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (data[i, j] != other.data[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator ==(Task2 m1, Task2 m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(Task2 m1, Task2 m2)
        {
            return !(m1 == m2);
        }

    }
}
