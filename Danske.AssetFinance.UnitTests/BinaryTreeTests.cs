using Danske.AssetFinance.Services;
using Xunit;

namespace Danske.AssetFinance.UnitTests
{
    public class BinaryTreeTests
    {
        private readonly BinaryTreeService _service;
        
        public BinaryTreeTests()
        {
            _service = new BinaryTreeService();
        }

        [Fact]
        public void TestSumOfOddEvenMaxPath1()
        {
            var input = new int[4][];
            input[0] = new[] {1};
            input[1] = new[] {8, 9};
            input[2] = new[] {1, 5, 9};
            input[3] = new[] {4, 5, 2, 3};

            var maxSum = _service.SumOfOddEvenMaxPath(input);
            Assert.Equal(16, maxSum);
        }
        
        [Fact]
        public void TestSumOfOddEvenMaxPath2()
        {
            var input = new int[15][];
            input[0] =  new[] {215};
            input[1] =  new[] {192, 124};
            input[2] =  new[] {117, 269, 442};
            input[3] =  new[] {218, 836, 347, 235};
            input[4] =  new[] {320, 805, 522, 417, 345};
            input[5] =  new[] {229, 601, 728, 835, 133, 124};
            input[6] =  new[] {248, 202, 277, 433, 207, 263, 257};
            input[7] =  new[] {359, 464, 504, 528, 516, 716, 871, 182};
            input[8] =  new[] {461, 441, 426, 656, 863, 560, 380, 171, 923};
            input[9] =  new[] {381, 348, 573, 533, 448, 632, 387, 176, 975, 449};
            input[10] = new[] {223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444};
            input[11] = new[] {330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197};
            input[12] = new[] {131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928};
            input[13] = new[] {223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121};
            input[14] = new[] {924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233};

            var maxSum = _service.SumOfOddEvenMaxPath(input);
            Assert.Equal(8186, maxSum);
        }
        
        [Fact]
        public void TestSumOfOddEvenMaxPath3()
        {
            var input = new int[2][];
            input[0] = new[] {2};
            input[1] = new[] {8, 1};

            var maxSum = _service.SumOfOddEvenMaxPath(input);
            Assert.Equal(3, maxSum);
        }
    }
}