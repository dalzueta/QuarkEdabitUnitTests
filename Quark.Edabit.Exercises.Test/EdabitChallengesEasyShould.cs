using Xunit;

namespace Quark.Edabit.Exercises.Test
{
    public class EdabitChallengesEasyShould
    {
        private EdabitChallengesEasy _sut;

        public EdabitChallengesEasyShould()
        {
            _sut = new EdabitChallengesEasy();
        }

        [Theory]
        [InlineData(5, 5, 3125)]
        [InlineData(10, 10, 10000000000)]
        [InlineData(3, 3, 27)]
        public void CalculateExponent_Numbers_Number(int number1, int number2, double expected)
        {
            /// Act
            var result = _sut.CalculateExponent(number1, number2);
            /// Assert 
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 1, 0 }, new int[] { 8, 12, 4, 0 })]
        [InlineData(new int[] { 4, 1, 1 }, new int[] { 12, 3, 3 })]
        [InlineData(new int[] { 1, 0, 3, 3, 7, 2, 1 }, new int[] { 7, 0, 21, 21, 49, 14, 7 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        public void MultiplyByLength_Array_Result(int[] arrayNumbers, int[] expected)
        {
            /// Act
            var result = _sut.MultiplyByLength(arrayNumbers);
            /// Assert 
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcde", "bcdef", 5)]
        [InlineData("abcde", "abcde", 0)]
        [InlineData("strong", "strung", 1)]
        public void HammingDistance_Strings_Number(string firstString, string secondString, int expected)
        {
            /// Act
            var result = _sut.HammerDistance(firstString, secondString);
            /// Assert 
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Donald Trump", "Trump Donald")]
        [InlineData("Rosie O'Donnell", "O'Donnell Rosie")]
        [InlineData("Seymour Butts", "Butts Seymour")]
        public void NameShaffle_String_Result(string firstAndLastName, string expected)
        {
            /// Act
            var result = _sut.NameShaffle(firstAndLastName);
            /// Assert 
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("21", "44", "21")]
        [InlineData("1500", "1", "1")]
        [InlineData("5", "5", "5")]
        public void SmallerNum_Numbers_Result(string firstNumber, string secondNumber, string expected)
        {
            /// Act
            var result = _sut.SmallerNum(firstNumber, secondNumber);
            /// Assert 
            Assert.Equal(expected, result);
        }
    }
}
