using Xunit;

namespace Quark.Edabit.Exercises.Test
{
    public class EdabitChallengesVeryEasyShould
    {
        private EdabitChallengesVeryEasy _sut;

        public EdabitChallengesVeryEasyShould()
        {
            _sut = new EdabitChallengesVeryEasy();
        }

        // Return the Sum of Two Numbers 
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-3, 6, 3)]
        [InlineData(3, 7, 10)]
        [InlineData(0.3, 0.7, 1)]
        public void SumTwoNumbers_GivenTwoNumbers_SumOfBoth(double number1, double number2, double expected)
        {
            /// Act
            var result = _sut.SubTwoNumbers(number1, number2);
            /// Assert
            Assert.Equal(expected, result);
        }

        //LessThanOrEqualToZero
        [Theory]
        [InlineData(2, false)]
        [InlineData(3.5, false)]
        [InlineData(-1, true)]
        [InlineData(0, true)]
        [InlineData(0.001, false)]
        [InlineData(100, false)]
        public void LessThanOrEqualToZero_NumberLessOrEqualToZero_True(double number, bool expected)
        {
            /// Act
            var result = _sut.LessThanOrEqualToZero(number);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Return Something to Me!
        [Theory]
        [InlineData("is better than nothing", "something is better than nothing")]
        [InlineData("Bob Jane", "something Bob Jane")]
        [InlineData("something", "something something")]
        public void GiveMeSomething_GivenString_SomthingConcatToTheString(string arg, string expected)
        {
            /// Act
            var result = _sut.GiveMeSomething(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Flip Boolean
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void Reverse_ABoolean_TheInverse(bool arg, bool expected)
        {
            /// Act
            var result = _sut.Reverse(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Convert Hours into Seconds
        [Theory]
        [InlineData(1, 3600)]
        [InlineData(2, 7200)]
        [InlineData(10, 36000)]
        [InlineData(2.5, 9000)]
        public void HowManySeconds_Hours_Seconds(double hours, double expected)
        {
            /// Act
            var result = _sut.HowManySeconds(hours);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Basic Variable Assignment
        [Theory]
        [InlineData("Mubashir", "MubashirEdabit")]
        [InlineData("Matt", "MattEdabit")]
        [InlineData("C#", "C#Edabit")]
        [InlineData("Fulanito", "FulanitoEdabit")]
        public void NameString_GivenAString_StringContactWithEdabit(string arg, string expected)
        {
            /// Act
            var result = _sut.NameString(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // 
        [Theory]
        [InlineData(true, false, false)]
        [InlineData(true, true, true)]
        [InlineData(false, true, false)]
        [InlineData(false, false, false)]
        public void And_TwoBooleans_AndCondition(bool firstArg, bool secondArg, bool expected)
        {
            /// Act
            var result = _sut.And(firstArg, secondArg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //  Basketball Points
        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(7, 5, 29)]
        [InlineData(38, 8, 100)]
        public void Points_CountOfDoublesAndTriples_PointsTotal(int doublesPoints, int triplesPoints, int expected)
        {
            /// Act
            var result = _sut.Points(doublesPoints, triplesPoints);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //  Find the Perimeter of a Rectangle
        [Theory]
        [InlineData(6, 7, 26)]
        [InlineData(20, 10, 60)]
        [InlineData(2, 9, 22)]
        public void FindPerimeter_LengthAndWidth_Perimeter(int length, int width, int expected)
        {
            /// Act
            var result = _sut.FindPerimeter(length, width);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //   Name Greeting!
        [Theory]
        [InlineData("Gerald", "Hello Gerald!")]
        [InlineData("Tiffany", "Hello Tiffany!")]
        [InlineData("Ed", "Hello Ed!")]

        public void HelloName_GivenAName_HelloName(string name, string expected)
        {
            /// Act
            var result = _sut.HelloName(name);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Farm
        [Theory]
        [InlineData(2, 3, 5, 36)]
        [InlineData(1, 2, 3, 22)]
        [InlineData(5, 2, 8, 50)]
        public void Animals_CountOfAnimals_LegsTotal(int chickens, int cows, int pigs, int expected)
        {
            /// Act
            var result = _sut.Animals(chickens, cows, pigs);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // FootballPoints
        [Theory]
        [InlineData(3, 4, 2, 13)]
        [InlineData(5, 0, 2, 15)]
        [InlineData(0, 0, 1, 0)]
        public void FootballPoints_CountsWinDrawsLosses_TotalPoints(int wins, int draws, int losses, int expected)
        {
            /// Act
            var result = _sut.FootballPoints(wins, draws, losses);
            /// Assert 
            Assert.Equal(expected, result);
        }





    }
}
