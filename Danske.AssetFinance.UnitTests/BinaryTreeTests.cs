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
        public void ReturnTrueTest()
        {
            var _is = _service.ReturnTrue();
            Assert.True(_is);
        }
    }
}