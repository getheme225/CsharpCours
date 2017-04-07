using System;

namespace HomeWork6
{
    public class Matrix
    {
        public uint NumberOfColums { get; private set; }
        public uint NumberOfRows { get; private set; }
        private readonly double[,] _matrixDoubles;
        private double _det;

        public Matrix(uint numberOfColums, uint numberOfRows)
        {
            NumberOfColums = numberOfColums;
            NumberOfRows = numberOfRows;   
            _matrixDoubles = new double[numberOfColums,numberOfRows];      
        }

        public Matrix(double[,] matrix)
        {
            this.NumberOfColums = (uint) matrix.GetLength(0);
            this.NumberOfRows = (uint) matrix.GetLength(1);
            this._matrixDoubles = matrix;
        }

        public double this[uint i, uint j]
        {
            get { return _matrixDoubles[i, j]; }
            set { _matrixDoubles[i, j] = value; }
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (Equals(firstMatrix.NumberOfColums, secondMatrix.NumberOfColums) &&
                Equals(firstMatrix.NumberOfRows, secondMatrix.NumberOfRows))
            {
                Matrix result = new Matrix(firstMatrix.NumberOfColums, secondMatrix.NumberOfRows);
                for (uint i = 0; i < result.NumberOfColums; i++)
                {
                    for (uint j = 0; j < result.NumberOfRows; j++)
                    {
                        result[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                    }
                }
                return result;
            }
            throw new Exception(" у эти 2 массивы нет одинаковых размеров");
        }

        public static Matrix operator +(Matrix firstMatrix, double number)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.NumberOfColums, firstMatrix.NumberOfRows);
            for (uint i = 0; i < resultMatrix.NumberOfColums; i++)
            {
                for (uint j = 0; j < resultMatrix.NumberOfRows; j++)
                {
                    resultMatrix[i, j] = firstMatrix[i, j] + number;
                }
            }
            return resultMatrix;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (Equals(firstMatrix.NumberOfRows, secondMatrix.NumberOfColums))
            {
                Matrix resultMatrix = new Matrix(firstMatrix.NumberOfColums, secondMatrix.NumberOfRows);
                for (uint i = 0; i < resultMatrix.NumberOfColums; i++)
                {
                    for (uint j = 0; j < resultMatrix.NumberOfRows; j++)
                    {
                        for (uint r = 0; r < secondMatrix.NumberOfRows; r++)
                        {
                            resultMatrix[i, j] = firstMatrix[i, r] * secondMatrix[r, j];
                        }
                    }
                }
                return resultMatrix;
            }
            throw new Exception("Матрицы нельзя перемножить, ps: матрицы должны быть такого вида A[N,M] B[M,P]");
        }

        public static Matrix operator *(Matrix firstMatrix, double number)
        {
            Matrix resultMatrix = new Matrix(firstMatrix.NumberOfColums, firstMatrix.NumberOfRows);
            for (uint i = 0; i < resultMatrix.NumberOfColums; i++)
            {
                for (uint j = 0; j < resultMatrix.NumberOfRows; j++)
                {
                    resultMatrix[i, j] = firstMatrix[i, j] * number;
                }
            }
            return resultMatrix;
        }

        public virtual Matrix TransposedMatrix
        {
            get { return TransposeMatrix(this); }

            private set { }
        }

        public virtual double Det
        {
            get
            {
                if (NumberOfColums == NumberOfRows)
                {
                    return GetDeterminant(this);
                }
                throw new Exception(
                    "Определитель можно расчитать только у матрицы с одинаковыми количествам столбцов и строков");
            }

            private set { _det = value; }
        }

        #region FindDeterminantAlgorithm

        private double GetDeterminant(Matrix matrix)
        {
            if (matrix.NumberOfColums == 2)
            {
                return (matrix[0, 0] * matrix[1, 1]) -
                       (matrix[0, 1] * matrix[1, 0]);
            }
            double sign = 1, result = 0;
            for (uint i = 0; i < matrix.NumberOfColums; i++)
            {
                Matrix minorDoubleMatrix = GetminorMatrix(matrix, i);
                result += sign * matrix[0, i] * GetDeterminant(minorDoubleMatrix);
                sign = -sign;
            }
            return result;
        }

        private Matrix GetminorMatrix(Matrix minorMatrix, uint minorPosition)
        {
            Matrix resultMinor = new Matrix(minorMatrix.NumberOfColums - 1, minorMatrix.NumberOfRows - 1);
            for (uint i = 1; i < minorMatrix.NumberOfColums; i++)
            {
                for (uint j = 0; j < minorPosition; j++)
                {
                    resultMinor[i - 1, j] = minorMatrix[i, j];
                    for (uint k = minorPosition + 1; k < minorMatrix.NumberOfColums; k++)
                    {
                        resultMinor[i - 1, k - 1] = minorMatrix[i, k];
                    }
                }
            }
            return resultMinor;
        }

        #endregion

        private Matrix TransposeMatrix(Matrix untranspodMatrix)
        {
            Matrix resultTranspose = new Matrix(untranspodMatrix.NumberOfColums, untranspodMatrix.NumberOfRows);
            for (uint i = 0; i < resultTranspose.NumberOfColums; i++)
            {
                for (uint j = 0; j < resultTranspose.NumberOfRows; j++)
                {
                    resultTranspose[j, i] = untranspodMatrix[i, j];
                }
            }
            return resultTranspose;
        }
    }
}





