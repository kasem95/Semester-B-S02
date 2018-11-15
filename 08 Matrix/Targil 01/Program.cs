using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiBoard;
            multiBoard = CreateMultiplicationBoard();
            PrintBoard(multiBoard);
        }

        static int[,] CreateMultiplicationBoard()
        {
            int[,] multi = new int[10, 10];
            int i = 0;
            int j = 0;
            for( i=0;i<10;i++)
            {
                for(j=0;j<10;j++)
                {
                    multi[i, j] = (i + 1) * (j+1);
                }
            }
            return multi;
        }
        static void PrintBoard(int[,] mat)
        {
            for(int i =0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    Console.Write(mat[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
