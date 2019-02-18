using System;
using System.Linq;

namespace Danske.AssetFinance.Services
{
    public class BinaryTreeService
    {
        public int SumOfOddEvenMaxPath(int[][] input)
        {
            var totalLines = input.Length;
            if (totalLines == 0 || totalLines != input[totalLines - 1].Length || input.Any(a => a.Any(n => n == 0)))
            {
                throw new Exception("Binary tree is not valid");
            }

            var firstLineType = GetOddEvenType(input[0][0]);

            var bottomLineType = GetLineType(totalLines - 1, firstLineType);
            input[totalLines - 1] = NullifyWrongTypeNumbers(input[totalLines - 1], bottomLineType);
            
            for (var i = (totalLines - 2); i >= 0; i--) 
            {
                for (var j = 0; j <= i; j++)
                {
                    var lineType = GetLineType(i, firstLineType);

                    if (!IsType(input[i][j], lineType))
                    {
                        input[i][j] = 0;
                        continue;
                    }
                    
                    var bottomLeftValue = input[i + 1][j];
                    var bottomRightValue = input[i + 1][j + 1];
                    var biggestValue = Math.Max(bottomLeftValue, bottomRightValue);
                    
                    if (biggestValue == 0)
                    {
                        input[i][j] = 0;
                    }
                    else
                    {
                        input[i][j] += biggestValue;
                    }
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

        private OddEven GetLineType(int lineIndex, OddEven firstLineType)
        {
            var type = firstLineType == OddEven.Even ? GetOddEvenType(lineIndex) : GetOddEvenType(lineIndex + 1);
            return type;
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