using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class MyMatrix
    {
        private int[,] matrix;

        public MyMatrix(int m, int n, int min_value, int max_value) // m - кол-во строк,
                                                                    // n - кол-во столбцов
        {
            int[,] new_matrix = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    new_matrix[i, j] =
                        RandomNumberGenerator.GetInt32(min_value, max_value);
                }
            }
            matrix = new_matrix;
        }

        public MyMatrix(int[,] mat) // конструктор (создание экземпляра по
                                    // передаваемой матрице(двумерному массиву))
        {
            matrix = mat;
        }

        public int this[int index_line, int index_column] // индексатор
        {
            get
            {
                return matrix[index_line, index_column];
            }
        }

        public static MyMatrix operator +(MyMatrix A, MyMatrix B) // сложение матриц
        {
            if (A.matrix.GetLength(0) != B.matrix.GetLength(0) ||
                A.matrix.GetLength(1) != B.matrix.GetLength(1))
            {
                return null;
            }

            int number_of_lines = A.matrix.GetLength(0);
            int number_of_columns = A.matrix.GetLength(1);
            int[,] matrix_sum = new int[number_of_lines, number_of_columns];

            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    matrix_sum[i, j] = A.matrix[i, j] + B.matrix[i, j];
                }
            }
            return new MyMatrix(matrix_sum);
        }

        public static MyMatrix operator -(MyMatrix A, MyMatrix B) // вычитание матриц
        {
            if (A.matrix.GetLength(0) != B.matrix.GetLength(0) ||
                A.matrix.GetLength(1) != B.matrix.GetLength(1))
            {
                return null;
            }

            int number_of_lines = A.matrix.GetLength(0);
            int number_of_columns = A.matrix.GetLength(1);
            int[,] matrix_sum = new int[number_of_lines, number_of_columns];

            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    matrix_sum[i, j] = A.matrix[i, j] - B.matrix[i, j];
                }
            }
            return new MyMatrix(matrix_sum);
        }

        public static MyMatrix operator *(int a, MyMatrix B) // умножение матрицы на число
        {
            if (B == null)
            {
                return null;
            }
            int number_of_lines = B.matrix.GetLength(0);
            int number_of_columns = B.matrix.GetLength(1);
            int[,] new_matrix = new int[number_of_lines, number_of_columns];

            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    new_matrix[i, j] = B.matrix[i, j] * a;
                }
            }
            return new MyMatrix(new_matrix);
        }

        public static MyMatrix operator *(MyMatrix B, int a) //     -//-
        {
            if (B == null)
            {
                return null;
            }
            int number_of_lines = B.matrix.GetLength(0);
            int number_of_columns = B.matrix.GetLength(1);
            int[,] new_matrix = new int[number_of_lines, number_of_columns];

            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    new_matrix[i, j] = B.matrix[i, j] * a;
                }
            }
            return new MyMatrix(new_matrix);
        }

        public static MyMatrix operator /(MyMatrix B, int a) // деление матрицы на число
        {
            if (B == null)
            {
                return null;
            }
            int number_of_lines = B.matrix.GetLength(0);
            int number_of_columns = B.matrix.GetLength(1);
            int[,] new_matrix = new int[number_of_lines, number_of_columns];

            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    new_matrix[i, j] = B.matrix[i, j] / a;
                }
            }
            return new MyMatrix(new_matrix);
        }

        public static MyMatrix operator *(MyMatrix A, MyMatrix B) // перемножение двух матриц
        {
            if (A.matrix.GetLength(1) != B.matrix.GetLength(0)) // в матрице А должно быть
                                                                // столько же столбцов,
                                                                // сколько строк в матрице B
            {
                return null;
            }

            int number_of_linesA = A.matrix.GetLength(0);
            int number_of_columnsA = A.matrix.GetLength(1);
            int number_of_columnsB = B.matrix.GetLength(1);
            int[,] new_matrix = new int[number_of_linesA, number_of_columnsB];

            for (int i = 0; i < number_of_linesA; ++i)
            {
                for (int j = 0; j < number_of_columnsB; ++j) // вычисление элемента (i, j)
                                                             // в новоой матрице
                {
                    int current_elem = 0;
                    for (int k = 0; k < number_of_columnsA; ++k)
                    {
                        current_elem += A.matrix[i, k] * B.matrix[k, j]; // реализация умножения
                                                                         // по принципу строка-столбец
                    }
                    new_matrix[i, j] = current_elem;
                }
            }
            return new MyMatrix(new_matrix);
        }

        public void writting_matrix() // метод вывода матрицы на экран
        {
            if (this == null) { return; }
            int number_of_lines = matrix.GetLength(0);
            int number_of_columns = matrix.GetLength(1);
            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
