using System;

namespace HomeWork6
{
    enum Operation
    {
        AddTwoMatrix,
        AddMatrixAndNumber,
        MultiplyTwoMatrix,
        MultiplyMatrixByNumber,
        TransposeMatrix,
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[,] elementsOfMatrixA = new double[3, 3]
            {
                {1, 2, 3},
                {0, 2, 5},
                {3, 2, 1}
            };
            double[,] elementsOfMatrixB = new double[3, 3]
            {
                {2, 3, 3},
                {4, 1, 3},
                {5, 3, 4}
            };
            Matrix matrixA = new Matrix(elementsOfMatrixA);
            Matrix matrixB = new Matrix(elementsOfMatrixB);

            Matrix matrix_A_and_B = matrixA + matrixB;
            ConsoleWriteMatrix(matrix_A_and_B, Operation.AddTwoMatrix);

            Matrix matrixA_and_3 = matrixA + 3;
            ConsoleWriteMatrix(matrixA_and_3, Operation.AddMatrixAndNumber);

            Matrix matrixA_per_B = matrixA * matrixB;
            ConsoleWriteMatrix(matrixA_per_B, Operation.MultiplyTwoMatrix);

            Matrix matrixA_per_3 = matrixA * 3;
            ConsoleWriteMatrix(matrixA_per_3, Operation.MultiplyMatrixByNumber);

            Matrix tMatrixA = matrixA.TransposedMatrix;
            ConsoleWriteMatrix(tMatrixA, Operation.TransposeMatrix);
            Console.WriteLine($"Определителя матрица А = {matrixA.Det}");
            Console.Read();
        }

        private static void PrintMatrix(Matrix matrix)
        {         
            for (uint i = 0; i < matrix.NumberOfColums; i++)
            {
                for (uint j = 0; j <matrix.NumberOfRows; j++)
                {
                   Console.Write(matrix[i,j] + "  " );
                }
                Console.WriteLine();
            }
        }

        private static void ConsoleWriteMatrix(Matrix matrix, Operation operation)
        {
            switch (operation)
            {
                case Operation.AddTwoMatrix:
                    Console.WriteLine("СЛОЖЕНИЕ МАТРИЦЫ А + B  =");
                    break;
                case Operation.AddMatrixAndNumber:
                    Console.WriteLine("СЛОЖЕНИЕ МАТРИЦА А + 3  =");
                    break;
                case Operation.MultiplyTwoMatrix:
                    Console.WriteLine("Умножение МАТРИЦЫ A X B =");
                    break;
                case Operation.MultiplyMatrixByNumber:
                    Console.WriteLine("Умножения матрица А на 3 =");
                    break;
                case Operation.TransposeMatrix:
                    Console.WriteLine("Транспонированна матрицы А = ");
                    break;
            }
            PrintMatrix(matrix);
            Console.WriteLine("--------------------------");
        }
    }
}
