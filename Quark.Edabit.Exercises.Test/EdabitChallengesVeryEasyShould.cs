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
        public void SumTwoNumbers_GivenTwoNumbers_SumOfBoth(int number1, int number2, double expected)
        {
            /// Act
            var result = _sut.Sum(number1, number2);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Convert minutes into seconds 
        [Theory]
        [InlineData(5, 300)]
        [InlineData(3, 180)]
        [InlineData(2, 120)]
        public void HowManySeconds_Minutes_Seconds(int minutes, int expected)
        {
            /// Act
            var result = _sut.ConvertMinutesToSeconds(minutes);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Return the next number from the integer passed 
        [Theory]
        [InlineData(0, 1)]
        [InlineData(9, 10)]
        [InlineData(-3, -2)]
        public void ReturnNextInteger_Number_NextNumber(int number, int expected)
        {
            /// Act
            var result = _sut.AddOne(number);
            /// Assert
            Assert.Equal(expected, result);
        }

        // PowerCalculator 
        [Theory]
        [InlineData(230, 10, 2300)]
        [InlineData(110, 3, 330)]
        [InlineData(480, 20, 9600)]
        public void CalculateElectricalPower_VoltageAndCurrent_CalculatedPower(int voltage, int current, int expected)
        {
            /// Act
            var result = _sut.CalculateElectricalPower(voltage, current);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Convert age to days
        [Theory]
        [InlineData(65, 23725)]
        [InlineData(0, 0)]
        [InlineData(20, 7300)]
        public void CalculateAgeInDays_Years_Days(int age, int expected)
        {
            /// Act
            var result = _sut.CalcAge(age);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Area of a Triangle 
        [Theory]
        [InlineData(3, 2, 3)]
        [InlineData(7, 4, 14)]
        [InlineData(10, 10, 50)]
        public void CalculateTriangleArea_BaseAndHeight_Area(int tBase, int area, int expected)
        {
            /// Act
            var result = _sut.TriArea(tBase, area);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Return the remainder from two numbers
        [Theory]
        [InlineData(1, 3, 1)]
        [InlineData(3, 4, 3)]
        [InlineData(-9, 45, -9)]
        [InlineData(5, 5, 0)]
        public void GetRemainder_Numbers_Remainder(int number1, int number2, int expected)
        {
            /// Act
            var result = _sut.Remainder(number1, number2);
            /// Assert
            Assert.Equal(expected, result);
        }

        //LessThanOrEqualToZero
        [Theory]
        [InlineData(5, false)]
        [InlineData(0, true)]
        [InlineData(-2, true)]
        public void LessThanOrEqualToZero_NumberLessOrEqualToZero_True(int number, bool expected)
        {
            /// Act
            var result = _sut.LessThanOrEqualToZero(number);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Less than 100?
        [Theory]
        [InlineData(22, 15, true)]
        [InlineData(83, 34, false)]
        [InlineData(3, 77, true)]
        public void LessThan100_NumbersToSum_TrueOrFalse(int number1, int number2, bool expected)
        {
            /// Act
            var result = _sut.LessThan100(number1, number2);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Are the numbers equal?
        [Theory]
        [InlineData(5, 6, false)]
        [InlineData(1, 1, true)]
        [InlineData(36, 35, false)]
        public void CheckNumbers_NumbersToCheck_TrueOrFalse(int number1, int number2, bool expected)
        {
            /// Act
            var result = _sut.IsEqual(number1, number2);
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

        // Using the "&&" operator
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

        // Basketball Points
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

        // Find the Perimeter of a Rectangle
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

        // Name Greeting!
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
