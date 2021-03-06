using System;
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
        public void SumTwoNumbers_GivenTwoNumbers_SumOfBoth(int number1, int number2, int expected)
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

        // Buggy Code (Part 4)
        [Theory]
        [InlineData("Matt", "Hello, Matt!")]
        [InlineData("Helen", "Hello, Helen!")]
        [InlineData("Mubashir", "Hello, my Love!")]

        public void Greeting_Name_GreetingsName(string name, string expected)
        {
            /// Act
            var result = _sut.Greeting(name);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Inches to feet
        [Theory]
        [InlineData(324, 27)]
        [InlineData(12, 1)]
        [InlineData(36, 3)]
        public void InchesToFeet_Inches_Feet(float inches, float expected)
        {
            /// Act
            var result = _sut.InchesToFeet(inches);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Sum of Polygon Angles
        [Theory]
        [InlineData(3, 180)]
        [InlineData(4, 360)]
        [InlineData(6, 720)]
        public void SumPolygon_Sides_SumOfAngles(int sides, int expected)
        {
            /// Act
            var result = _sut.SumPolygon(sides);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Check if an integer is divisible by five
        [Theory]
        [InlineData(5, true)]
        [InlineData(-55, true)]
        [InlineData(37, false)]
        public void DivisibleByFive_Number_TrueOrFalse(int number, bool expected)
        {
            /// Act
            var result = _sut.DivisibleByFive(number);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Correct the Mistakes
        [Theory]
        [InlineData(5, 25)]
        [InlineData(9, 81)]
        [InlineData(100, 10000)]
        public void Squared_Number_SquaredNumber(int number, int expected)
        {
            /// Act
            var result = _sut.Squared(number);
            /// Assert 
            Assert.Equal(expected, result);
        }



        // Flip the Integer boolean
        [Theory]
        [InlineData(1, 0)]
        [InlineData(0, 1)]
        public void FlipIntBool_IntBoolean_OppositeIntBoolean(int number, int expected)
        {
            /// Act
            var result = _sut.FlipIntBool(number);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //  Divides evenly
        [Theory]
        [InlineData(98, 7, true)]
        [InlineData(85, 4, false)]
        public void dividesEvenly_TwoIntegers_IsOneDivisibleEvenly(int number1, int number2, bool expected)
        {
            /// Act
            var result = _sut.DividesEvenly(number1, number2);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //  Frames per second
        [Theory]
        [InlineData(1, 1, 60)]
        [InlineData(10, 1, 600)]
        [InlineData(10, 25, 15000)]
        public void Frames_FpsAndMinutes_FpsByMinutes(int minutes, int fps, int expected)
        {
            /// Act
            var result = _sut.Frames(minutes, fps);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //  Profitable Gamble
        [Theory]
        [InlineData(0.2, 50, 9, true)]
        [InlineData(0.9, 1, 2, false)]
        [InlineData(0.9, 3, 2, true)]
        public void ProfitableGamble_ProbPrizeAndPay_IsProfitable(double prob, double prize, double pay, bool expected)
        {
            /// Act
            var result = _sut.ProfitableGamble(prob, prize, pay);
            /// Assert 
            Assert.Equal(expected, result);
        }

        //  Multiple of 100 
        [Theory]
        [InlineData(1, false)]
        [InlineData(1000, true)]
        [InlineData(100, true)]
        public void Divisible_Number_Bool(int number, bool expected)
        {
            /// Act
            var result = _sut.Divisible(number);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Verify date Chrismas Eve
        [Theory]
        [InlineData(2013, 12, 24, true)]
        [InlineData(2013, 0, 23, false)]
        [InlineData(3000, 12, 24, true)]
        public void Date_Chrismas_Eve(
            int year, int month, int date, bool expected)
        {
            /// Act
            var result = _sut.Date_Chrismas_Eve(month, date);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Fibonachi 
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(100, 198)]
        public void Nth_Even_Number(int arg, int expected)
        {
            /// Act
            var result = _sut.Nth_Even_Number(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Negative Number
        [Theory]
        [InlineData(4, -4)]
        [InlineData(15, -15)]
        [InlineData(-4, -4)]
        [InlineData(0, 0)]
        public void Negative_Number(int arg, int expected)
        {
            /// Act
            var result = _sut.Negative_Number(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Methods ABS
        [Theory]
        [InlineData(-3, 3)]
        [InlineData(250, 250)]
        public void Methods_ABS(int arg, int expected)
        {
            /// Act
            var result = _sut.Methods_ABS(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Coffee Cup
        [Theory]
        [InlineData(6, 7)]
        [InlineData(12, 14)]
        [InlineData(213, 248)]
        public void Coffee_Cup(double arg, double expected)
        {
            /// Act
            double result = _sut.Coffee_Cup(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Stack the boxes
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(0, 0)]
        public void Stack_The_Boxes(int arg, int expected)
        {
            /// Act
            int result = _sut.Stack_The_Boxes(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Buggy Code Part 5
        [Theory]
        [InlineData(1, new int[] { 1 })]
        [InlineData(3, new int[] { 1 , 2, 3 })]
        [InlineData(6, new int[] { 1 , 2, 3, 4 , 5, 6 })]
        public void Buggy_Code_Part5(int arg, int[] expected)
        {
            /// Act
            Array result = _sut.Buggy_Code_Part5(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Concatenate
        [Theory]
        [InlineData("First", "Last", "Last, First")]
        [InlineData("Jhon", "Doe", "Doe, Jhon")]
        [InlineData("Mary", "Jane", "Jane, Mary")]
        public void Concatenate_First_And_Last_Name(string first, string last, string expected)
        {
            /// Act
            string result = _sut.Concatenate_First_And_Last_Name(first, last);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Drinks_allowed
        [Theory]
        [InlineData(17, true, false)]
        [InlineData(19, false, true)]
        [InlineData(30, true, false)]
        public void Drinks_Allowed(int age, bool breackBarman, bool expected)
        {
            /// Act
            var result = _sut.Drinks_Allowed(age, breackBarman);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // String_Empty
        [Theory]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("a", false)]
        public void String_Empty(string arg, bool expected)
        {
            /// Act
            var result = _sut.String_Empty(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Compare Strings by count of characters 
        [Theory]
        [InlineData("AB", "CD", true)]
        [InlineData("ABC", "DE", false)]
        public void Comp_StringsToCompareLength_LengthComparisonBoolean(string str1, string str2, bool expected)
        {
            /// Act
            bool result = _sut.Comp(str1, str2);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Area of a rectangle  
        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(-1, 5, -1)]
        [InlineData(0, 2, -1)]
        public void Area_RectangleSidesLength_RectangleArea(int side1, int side2, int expected)
        {
            /// Act
            int result = _sut.Area(side1, side2);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Is the string odd or even?
        [Theory]
        [InlineData("apples", true)]
        [InlineData("pears", false)]
        [InlineData("cherry", true)]
        public void OddOrEven_string_FalseIfOddTrueIfEven(string str, bool expected)
        {
            /// Act
            bool result = _sut.OddOrEven(str);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Is the number even or odd?
        [Theory]
        [InlineData(3, "odd")]
        [InlineData(146, "even")]
        [InlineData(19, "odd")]
        public void IsEvenOrOdd_Number_EvenOrOddString(int number, string expected)
        {
            /// Act
            string result = _sut.IsEvenOrOdd(number);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Recursion: Length of a string
        [Theory]
        [InlineData("apple", 5)]
        [InlineData("make", 4)]
        [InlineData("a", 1)]
        [InlineData("", 0)]
        public void Length_Word_WordLength(string word, int expected)
        {
            /// Act
            int result = _sut.Length(word);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Max Min difference
        [Theory]
        [InlineData(new int[] { 10, 15, 20, 2, 10, 6 }, 18)]
        [InlineData(new int[] { -3, 4, -9, -1, -2, 15 }, 24)]
        [InlineData(new int[] { 4, 17, 12, 2, 10, 2 }, 15)]
        public void Diff_ArrayOfNumbers_DifferenceBetweenMinAndMax(int[] numbers, int expected)
        {
            /// Act
            int result = _sut.Diff(numbers);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Fix the error: Check whether a given number is odd
        [Theory]
        [InlineData(-5 , true)]
        [InlineData(25, true)]
        [InlineData(0, false)]
        public void IsOdd_Number_TrueIfOdd(int number, bool expected)
        {
            /// Act
            bool result = _sut.IsOdd(number);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Return a string as an Integer
        [Theory]
        [InlineData("6", 6)]
        [InlineData("1000", 1000)]
        [InlineData("12", 12)]
        public void StringInt_string_ParsedInt(string number, int expected)
        {
            /// Act
            int result = _sut.StringInt(number);
            /// Assert 
            Assert.Equal(expected, result);
        }
    }
}
