using Xunit;

namespace Quark.Edabit.Exercises.Test
{
    public class EdabitChallengesVeryHardShould
    {
        private EdabitChallengesVeryHard _sut;

        public EdabitChallengesVeryHardShould()
        {
            _sut = new EdabitChallengesVeryHard();
        }

        // Valid Rondo form?
        [Theory]
        [InlineData("ABACADAEAFAGAHAIAJA", true)]
        [InlineData("ACAC", false)]
        [InlineData("ABA", true)]
        [InlineData("A", false)]
        [InlineData("", false)]

        public void IsAValidRondo_MusicSequence_IfIsARondo(string sequence, bool expected)
        {
            /// Act
            var result = _sut.IsAValidRondo(sequence);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //Fibonacci word
        [Theory]
        [InlineData(3, "b, a, ab")]
        [InlineData(1, "invalid")]
        [InlineData(7, "b, a, ab, aba, abaab, abaababa, abaababaabaab")]

        public void GetFibonacciWordSequence(int sequenceLength, string expected) {
            /// Act
            var result = _sut.GetFibonacciWordSequence(sequenceLength);
            /// Assert
            Assert.Equal(expected, result);
        }

        //Simplified fractions
        [Theory]
        [InlineData("4/6", "2/3")]
        [InlineData("11/10", "11/10")]
        [InlineData("16000/4000", "4/1")]

        public void SimplifyFraction(string fraction, string expected)
        {
            /// Act
            var result = _sut.SimplifyFraction(fraction);
            /// Assert
            Assert.Equal(expected, result);
        }
    }
}
