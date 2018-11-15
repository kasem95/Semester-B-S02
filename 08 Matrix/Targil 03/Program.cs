using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[1, 1] { { 1 } };
            bool toContinue = false;
            string yesOrNo = "";
            do
            {
                mat = PumpMatrix(mat);
                PrintBoard(mat);
                Console.WriteLine("do you want to continue?(if yes enter y)");
                yesOrNo = Console.ReadLine();
                if (yesOrNo == "y")
                {
                    toContinue = true;
                }
            } while (toContinue);

        }
        static int[,] PumpMatrix(int[,] matrix)
        {
            int[,] mat = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
            CopyMatrixValues(matrix, mat);
            
            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    mat[i, matrix.GetLength(1)] += matrix[i, j];
                    mat[matrix.GetLength(1), i] += matrix[j, i];
                }
            }



            return mat;
        }
        static void PrintBoard(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void CopyMatrixValues(int[,] sourceMatrix, int[,] destinationMatrix)
        {
            for (int i = 0; i < destinationMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < destinationMatrix.GetLength(1) - 1; j++)
                {
                    destinationMatrix[i, j] = sourceMatrix[i, j];
                }
            }
        }
    }
}
