using System;

namespace Danske.AssetFinance.Services
{
    public class BinaryTreeService
    {
        public int SumOfOddEvenMaxPath(int[][] input)
        {
            var totalLines = input.Length;
            if (totalLines == 0 || totalLines != input[totalLines - 1].Length)
            {
                throw new Exception("Binary tree is not valid");
            }

            var bottomLineType = GetOddEvenType(totalLines);
            input[totalLines - 1] = NullifyWrongTypeNumbers(input[totalLines - 1], bottomLineType);
            
            
            for (var i = (totalLines - 2); i >= 0; i--) 
            { 
                for (var j = 0; j <= i; j++)
                {
                    var lineType = GetOddEvenType(i + 1);

                    if (!IsType(input[i][j], lineType))
                    {
                        input[i][j] = 0;
                        continue;
                    }
                    
                    var bottomLeftValue = input[i + 1][j];
                    var bottomRightValue = input[i + 1][j + 1];

                    input[i][j] += Math.Max(bottomLeftValue, bottomRightValue);
                } 
            }

            return input[0][0];
        }

        private int[] NullifyWrongTypeNumbers(int[] array, OddEven type)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (!IsType(array[i], type))
                {
                    array[i] = 0;
                }
            }

            return array;
        }
            
        private bool IsType(int value, OddEven type)
        {
            return GetOddEvenType(value) == type;
        }
        
        private OddEven GetOddEvenType(int value)
        {
            return value % 2 != 0 ? OddEven.Odd : OddEven.Even;
        }
    }

    public enum OddEven
    {
        Odd,
        Even
    }
}