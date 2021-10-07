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
        [InlineData(11211230, false)]  // 2333 // 56
        [InlineData(13001120, true)]   // 4022 // 44
        [InlineData(23336014, true)]   // 5665
        [InlineData(11, true)]         // 11
        public void PalindromeDescendant_integer_IsPalindromeDescendant(int number, bool expected)
        {
            /// Act
            var result = _sut.IsPalindromeDescendant(number);
            /// Assert
            Assert.Equal(expected, result);
        }


    }
}
