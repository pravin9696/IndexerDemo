using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo._250924_1
{
    internal class Matrix
    {
        int[,] mat;
        //r=0,1,2   c=0,1,2

        public Matrix(int[,]t)
        {
            mat = new int[t.GetLength(0), t.GetLength(1)];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = t[i, j];
                }
            }
        }
        public int this[int row, int col]
        {
            set {
                mat[row, col] = value;            
            }
            get { return mat[row, col]; }
        }
        

    }
}
