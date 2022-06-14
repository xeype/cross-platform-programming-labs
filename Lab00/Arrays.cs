using System;

namespace Lab00
{
    class Arrays
    {
        private static int[][] _jaggedArray = new int[4][];
        private static int[] _rowSum = new int[4];
        private static int _sum;

        private static void EnterArray()
        {
            for (var i = 0; i < _jaggedArray.Length; i++)
            {
                Console.WriteLine("Row " + i);
                var rowLength = Random.Shared.Next(1, 5);
                _jaggedArray[i] = new int[rowLength];

                for (var j = 0; j < _jaggedArray[i].Length; j++)
                {
                    Console.Write("Element " + j + ": ");
                    _jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                    SummarizeRow(i, _jaggedArray[i][j]);
                }

                _sum = 0;
            }
        }

        private static void SummarizeRow(int row, int num)
        {
            _sum += num;
            _rowSum[row] = _sum;
        }

        private static int[] FindMaxRowIndexes()
        {
            var max = _rowSum[0];
            var countOfMaxRow = 0;

            for (var i = 0; i < _rowSum.Length; i++)
            {
                if (_rowSum[i] > max)
                    max = _rowSum[i];
            }

            for (var i = 0; i < _rowSum.Length; i++)
            {
                if (_rowSum[i] == max) countOfMaxRow++;
            }

            var maxRowIndexes = new int[countOfMaxRow];
            var k = 0;
            for (var i = 0; i < _rowSum.Length; i++)
            {
                if (_rowSum[i] == max)
                {
                    maxRowIndexes[k] = i;
                    k++;
                }
            }

            return maxRowIndexes;
        }

        private static int FindMinRowIndex()
        {
            var min = _rowSum[0];
            for (var i = 0; i < _rowSum.Length; i++)
            {
                if (_rowSum[i] < min)
                    min = _rowSum[i];
            }

            for (var i = 0; i < _rowSum.Length; i++)
            {
                if (_rowSum[i] == min)
                {
                    return i;
                }
            }

            return -1;
        }

        private static int[][] ModifyArray(int[] maxRowIndexes, int minRowIndex)
        {
            int count = 0;
            var countOfMaxRow = maxRowIndexes.Length;
            int[][] modifiedArray = new int[4 + countOfMaxRow][];

            for (var i = 0; i < modifiedArray.Length; i++)
            {
                for (var k = 0; k < maxRowIndexes.Length; k++)
                {
                    if (i == maxRowIndexes[k])
                    {
                        count++;

                        modifiedArray[i] = new int[_jaggedArray[maxRowIndexes[k]].Length];
                        for (var j = 0; j < _jaggedArray[maxRowIndexes[k]].Length; j++)
                        {
                            modifiedArray[i][j] = _jaggedArray[maxRowIndexes[k]][j];
                        }

                        i++;

                        modifiedArray[i] = new int[_jaggedArray[minRowIndex].Length];
                        for (var j = 0; j < _jaggedArray[minRowIndex].Length; j++)
                        {
                            modifiedArray[i][j] = _jaggedArray[minRowIndex][j];
                        }
                    }
                    else
                    {
                        modifiedArray[i] = new int[_jaggedArray[i - count].Length];
                        for (var j = 0; j < _jaggedArray[i - count].Length; j++)
                        {
                            modifiedArray[i][j] = _jaggedArray[i - count][j];
                        }
                    }
                }
            }

            return modifiedArray;
        }

        private static void OutputArray(int[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            EnterArray();
            
            Console.WriteLine("Initial Array: ");
            OutputArray(_jaggedArray);
            
            var maxRowIndexes = FindMaxRowIndexes();
            var minRowIndex = FindMinRowIndex();
            var modifiedArray = ModifyArray(maxRowIndexes, minRowIndex);

            Console.WriteLine("Modified Array: ");
            OutputArray(modifiedArray);
        }
    }
}