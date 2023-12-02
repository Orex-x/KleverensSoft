using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleverensSoft
{
    public class Task2
    {
       
        public static int[] SpiralOrder(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int[] result = new int[m * n];

            int rowStart = 0, rowEnd = m - 1;
            int colStart = 0, colEnd = n - 1;

            int index = 0;

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                // Traverse down
                for (int i = rowStart; i <= rowEnd; i++)
                {
                    result[index++] = matrix[i, colStart];
                }
                colStart++;


                // Traverse right
                for (int i = colStart; i <= colEnd; i++)
                {
                    result[index++] = matrix[rowEnd, i];
                }
                rowEnd--;



                // Traverse left
                if (colStart <= colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        result[index++] = matrix[i, colEnd];
                    }
                    colEnd--;
                }

                // Traverse up
                if (rowStart <= rowEnd)
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        result[index++] = matrix[rowStart, i];
                    }
                    rowStart++;
                }
            }

            return result;
        }
    }
}
