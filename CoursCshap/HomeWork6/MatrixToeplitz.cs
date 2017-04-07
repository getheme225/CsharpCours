using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class MatrixToeplitz:Matrix
    {
        private bool _isMatrixToeplitz;

        public MatrixToeplitz(uint numberColums, uint numberOfRows) : base(numberColums, numberOfRows)
        {
        }

        public MatrixToeplitz(double[,] matrix) : base(matrix)
        {
        }

        public static Matrix operator +(MatrixToeplitz firstMatrixToeplitz, MatrixToeplitz secondMatrixToeplitz)
        {
            throw new NotImplementedException();
        }

        public static Matrix operator *(MatrixToeplitz firstMatrixToeplitz, double number)
        {
            throw new NotImplementedException();
        }

        public override double Det => 0;

        public override Matrix TransposedMatrix
        {
            get { throw new NotImplementedException(); }
        }
    }
}
