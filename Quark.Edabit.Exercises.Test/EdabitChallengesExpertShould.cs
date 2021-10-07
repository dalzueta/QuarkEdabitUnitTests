using Xunit;

namespace Quark.Edabit.Exercises.Test
{
    public class EdabitChallengesExpertShould
    {
        private EdabitChallengesExpert _sut;

        public EdabitChallengesExpertShould()
        {
            _sut = new EdabitChallengesExpert();
        }

        [Theory]
        [InlineData(11211230, false)]
        [InlineData(13001120, true)]
        [InlineData(23336014, true)]
        [InlineData(11, true)]
        public void SumTwoNumbers(int number, bool expected)
        {
            /// Act
            var result = _sut.palindromeDescendant(number);
            /// Assert
            Assert.Equal(expected, result);
        }


    }
}
