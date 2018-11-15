using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] cur = new double[,] { { 3.544, 3.691, 3.623, 0 },
                                            { 4.73, 5.0823, 5.0059, 0},
                                            { 4.3551, 4.5272,4.4113,0},
                                            { 5.493, 5.9473, 5.8959,0} };
            string[] currNames = new string[] { "Dollar", "Euro", "Yen", "GBP" };
            string table = TablString(cur, currNames);
            AverageRows(cur);
            table = TablString(cur, currNames);
            Console.WriteLine(table);
            for(int i = 0;i<cur.GetLength(0);i++)
            {
                Console.Write((SumColumns(cur)[i]) + " ");
            }
            Console.WriteLine();
        }
        static void AverageRows(double[,] table)
        {
            double sum;
            int i = 0;
            int j = 0;
            for (; i < table.GetLength(0); i++)
            {
                sum = 0;
                for (j=0; j < table.GetLength(1)-1; j++)
                {
                    sum += table[i, j];
                }
                table[i, j] = sum / (j);
            }
            
        }
        static string TablString(double[,] table,string[] names)
        {
            string allString = "";
            for(int i = 0; i<names.Length;i++)
            {
                allString += names[i] + "\t";
                for(int j=0;j<table.GetLength(1);j++)
                {
                    allString += table[i, j] + "\t";
                }
            }
            return allString;
        }

        static double[] SumColumns(double[,] table)
        {
            double[] sum = new double[table.GetLength(0)];
            double rowSum;
            for(int i=0;i<table.GetLength(0);i++)
            {
                rowSum = 0;
                for(int j= 0;j<table.GetLength(1);j++)
                {
                    rowSum += table[i, j];
                }
                sum[i] = rowSum;
            }
            return sum;
        }
    }
}
