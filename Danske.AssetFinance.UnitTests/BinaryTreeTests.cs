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
    }
}