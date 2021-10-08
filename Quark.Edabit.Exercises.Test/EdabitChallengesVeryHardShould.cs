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

        //New driving licence
        [Theory]
        [InlineData("Eric", 2, "Adam Caroline Rebecca Frank", 40)]
        [InlineData("Zebediah", 1, "Bob Jim Becky Pat", 100)]
        [InlineData("Aaron", 3, "Jane Max Olivia Sam", 20)]

        public void TimeToGetLicense(string myName, int agentQuantity, string otherPeopleNames, int expected)
        {
            /// Act
            var result = _sut.TimeToGetLicense(myName, agentQuantity, otherPeopleNames);
            /// Assert
            Assert.Equal(expected, result);
        }

        //Working 9 to 5
        [Theory]
        [InlineData(new float[] { 9, 17, 30, 1.5f }, "$240.00")]
        [InlineData(new float[] { 16, 18, 30, 1.8f }, "$84.00")]
        [InlineData(new float[] { 13.25f, 15, 30, 1.5f }, "$52.50")]
        [InlineData(new float[] { 18, 19, 30, 2f }, "$60.00")]
        [InlineData(new float[] { 17, 19, 30, 3f }, "$180.00")]

        public void calculatePay(float[] workingDayValues, string expected)
        {
            /// Act
            var result = _sut.payCalculator(workingDayValues);
            /// Assert
            Assert.Equal(expected, result);
        }

        //Knights on a board
        [Fact]
        public void AKnightIsInDanger()
        {
            /// Arrange
            int[,] chessBoard = new int[,]
            {
                { 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 0, 0 }
            };
            /// Act
            var result = _sut.CheckIfAnyKnightCanCapture(chessBoard);
            /// Assert
            Assert.True(result);
        }

        [Fact]
        public void AKnightIsNotInDanger()
        {
            /// Arrange
            int[,] chessBoard = new int[,]
            {
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 1},
                {1, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {1, 0, 0, 1, 0, 0, 0, 1}
            };
            /// Act
            var result = _sut.CheckIfAnyKnightCanCapture(chessBoard);
            /// Assert
            Assert.False(result);
        }

    }
}
