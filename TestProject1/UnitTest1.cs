using FirstRequirement;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private static IConsole _c { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void IfNameIsEmptyRepeatTheRead()
        {
            //arrange
            var name = "dummyTest";

            //act
            var res = Program.ReadName(string.Empty, new TestConsoleWrapperForEmpty());

            //assert
            Assert.AreEqual(name, res);
        }


        [Test]
        public static void IfNameContainsDigitsRepeatTheRead()
        {
            //arrange
            var name = "dummyTest";

            //act
            var res = Program.ReadName(name, new TestConsoleWrapperForDigits());

            //assert
            Assert.AreEqual(name, res);
        }

        [Test]
        public static void IfNameContainsSpecialCharsRepeatTheRead()
        {
            //arrange
            var name = "dummyTest";

            //act
            var res = Program.ReadName(name, new TestConsoleWrapperForSpecialChars());

            //assert
            Assert.AreEqual(name, res);
        }

        [Test]
        public static void IfNameIsCorrectReturnIt()
        {
            //assert
            var name = "dummyTest";

            //act
            var res = Program.ReadName(name, new TestConsoleWrapperForCorrectName());

            //assert
            Assert.AreEqual(name, res);
        }
    }
}