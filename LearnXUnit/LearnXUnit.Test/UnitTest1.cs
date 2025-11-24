using Xunit;

namespace LearnXUnit.Test
{
    //Use this link for XUnit documentation https://xunit.net/#documentation
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Assert.Equal(1, 1); //this worked fine - as you'd expect
            //Arrange
            //var l = new LearnXUnit.Test
            //var entryPoint = typeof(Program).Assembly.EntryPoint!;

            // I've asked a question on SO for clarification: https://stackoverflow.com/questions/70645272/is-there-a-way-to-unit-test-top-level-statements-in-c

            //Act

            //Assert
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            //var program = new LearnXUnit.Program();
            int a = 2;
            int b = 3;
            // Act
            int result = LearnXUnit.Program.Add2(a, b);
            // Assert
            Assert.Equal(5, result);
        }
    }
}