using Xunit;
using LearnXUnit;

namespace LearnXUnit.Test
{
    //Use this link for XUnit documentation https://xunit.net/#documentation
    public class UnitTest1
    {
        [Fact]
        public void Test2()
        {
            // Arrange
            //var program = new LearnXUnit.Program();
            int a = 2;
            int b = 3;
            // Act
            //int result = LearnXUnit.Program.Add2(a, b);
            int bozo = LearnXUnit.Program.Add2(a, b);
            // Assert
            Assert.Equal(5, bozo);
        }
    }
}