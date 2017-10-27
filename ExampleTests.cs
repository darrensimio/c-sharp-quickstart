using Xunit;

namespace c_sharp_quickstart
{
    public class ExampleTests 
    {
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(3, (1+3));
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, (1+3));
        }
    }
}