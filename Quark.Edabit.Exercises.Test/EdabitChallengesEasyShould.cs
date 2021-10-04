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

        // To the power of _____
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

        // Multiply by Length
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

        // Hamming distance
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

        // Shuffle the name
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

        // Smaller string number
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

        // Return the factorial 
        [Theory]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        [InlineData(12, 479001600)]
        public void Factorial_Number_FactorialOfNumber(int number, int expected)
        {
            /// Act
            var result = _sut.Factorial(number);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // How many vowels?
        [Theory]
        [InlineData("Celebration", 5)]
        [InlineData("Palm", 1)]
        [InlineData("Prediction", 4)]
        public void CountVowels_String_NumberOfVowels(string phrase, int expected)
        {
            /// Act
            var result = _sut.CountVowels(phrase);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Sort numbers in ascending order
        [Theory]
        [InlineData(new int[] { 1, 2, 10, 50, 5 }, new int[] { 1, 2, 5, 10, 50 })]
        [InlineData(new int[] { 80, 29, 4, -95, -24, 85 }, new int[] { -95, -24, 4, 29, 80, 85 })]
        [InlineData(null, new int[] { })]
        [InlineData(new int[] { }, new int[] { })]
        public void SortNumsAscending_UnordenedArray_OrdenedArray(int[] array, int[] expected)
        {
            /// Act
            var result = _sut.SortNumsAscending(array);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Check if a string contains only identical characters
        [Theory]
        [InlineData("aaaaaa", true)]
        [InlineData("aabaaa", false)]
        [InlineData("ccccca", false)]
        public void IsIdentical_String_TrueOrFalse(string phrase, bool expected)
        {
            /// Act
            var result = _sut.IsIdentical(phrase);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // h4ck3r sp34k
        [Theory]
        [InlineData("javascript is cool", "j4v45cr1pt 15 c00l")]
        [InlineData("programming is fun", "pr0gr4mm1ng 15 fun")]
        [InlineData("become a coder", "b3c0m3 4 c0d3r")]
        public void HackerSpeak_Phrase_ModifiedPhrase(string phrase, string expected)
        {
            /// Act
            var result = _sut.HackerSpeak(phrase);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Check if the same case
        [Theory]
        [InlineData("hello", true)]
        [InlineData("HELLO", true)]
        [InlineData("Hello", false)]
        [InlineData("ketcHUp", false)]

        public void SameCase_String_CheckIfContainsOnlyUpperOrLowercase(string word, bool expected)
        {
            /// Act
            var result = _sut.SameCase(word);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // How many D's Are there
        [Theory]
        [InlineData("My friend Dylan got distracted in school.", 4)]
        [InlineData("Debris was scattered all over the yard", 3)]
        [InlineData("The rodents hibernated in their den.", 3)]

        public void CountDs_String_DsCount(string phrase, int expected)
        {
            /// Act
            var result = _sut.CountDs(phrase);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Shapes with N sides
        [Theory]
        [InlineData(3, "triangle")]
        [InlineData(1, "circle")]
        [InlineData(9, "nonagon")]

        public void NSidedShape_Sides_Shape(int sides, string expected)
        {
            /// Act
            var result = _sut.NSidedShape(sides);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Raucous Applause
        [Theory]
        [InlineData("ClaClaClaClap!", 4)]
        [InlineData("ClClClaClaClaClap!", 6)]
        [InlineData("CCClaClClap!Clap!ClClClap!", 9)]

        public void CountClaps_String_NumberOfClaps(string claps, int expected)
        {
            /// Act
            var result = _sut.CountClaps(claps);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Burrrrrrrp
        [Theory]
        [InlineData(3, "Burrrp")]
        [InlineData(5, "Burrrrrp")]
        [InlineData(9, "Burrrrrrrrrp")]

        public void LongBurp_NumberOfRs_NewBurp(int numberOfRs, string expected)
        {
            /// Act
            var result = _sut.LongBurp(numberOfRs);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Remove the first and last characters
        [Theory]
        [InlineData("hello", "ell")]
        [InlineData("maybe", "ayb")]
        [InlineData("benefit", "enefi")]
        [InlineData("a", "a")]
        public void RemoveFirstLast_String_CutString(string phrase, string expected)
        {
            /// Act
            var result = _sut.RemoveFirstLast(phrase);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Date format
        [Theory]
        [InlineData("11/12/2019", "20191211")]
        [InlineData("12/31/2019", "20193112")]
        [InlineData("01/15/2019", "20191501")]
        public void FormatDate_Date_FormatedDate(string date, string expected)
        {
            /// Act
            var result = _sut.FormatDate(date);
            /// Assert
            Assert.Equal(expected, result);
        }


        // FizzBuzz interview question
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(4, "4")]
        public void FizzBuzz_Number_FizzBuzzResult(int number, string expected)
        {
            /// Act
            var result = _sut.FizzBuzz(number);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Recursion to repeat a string N number of times 
        [Theory]
        [InlineData("ab", 3, "ababab")]
        [InlineData("kiwi", 1, "kiwi")]
        [InlineData("cherry", 2, "cherrycherry")]
        public void Repetition_StringAndNumber_RepeatedString(string phrase, int times, string expected)
        {
            /// Act
            var result = _sut.Repetition(phrase, times);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Repeating Letters
        [Theory]
        [InlineData("String", "SSttrriinngg")]
        [InlineData("Hello World!", "HHeelllloo  WWoorrlldd!!")]
        [InlineData("1234!_ ", "11223344!!__  ")]
        public void DoubleChar_String_RepeteadString(string phrase, string expected)
        {
            /// Act
            var result = _sut.DoubleChar(phrase);
            /// Assert
            Assert.Equal(expected, result);
        }

        // Hashes and Pluses
        [Theory]
        [InlineData("###+", new int[] { 3, 1 })]
        [InlineData("##+++#", new int[] { 3, 3 })]
        [InlineData("#+++#+#++#", new int[] { 4, 6 })]
        [InlineData("", new int[] { 0, 0 })]
        public void HashPlusCount_String_HashesPlusesCount(string str, int[] expected)
        {
            /// Act
            var result = _sut.HashPlusCount(str);
            /// Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 }, "(519) 555-4468")]
        [InlineData(new int[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 }, "(345) 501-2527")]
        public void FormatPhoneNumber_intArray_FormatedPhoneNumber(int[] numbers, string expected)
        {
            /// Act
            var result = _sut.FormatPhoneNumber(numbers);
            /// Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("mice", 5, "mmmmmiiiiiccccceeeee")]
        [InlineData("hello", 3, "hhheeellllllooo")]
        [InlineData("stop", 1, "stop")]

        public void Repeat_StringAndCount_RepeatedCharacters(string str, int count, string expected)
        {
            /// Act
            var result = _sut.Repeat(str, count);
            /// Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("space", "s p a c e")]
        [InlineData("far out", "f a r   o u t")]
        [InlineData("elongated musk", "e l o n g a t e d   m u s k")]

        public void SpaceMeOut_String_SpacedString(string str, string expected)
        {
            /// Act
            var result = _sut.SpaceMeOut(str);
            /// Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 }, 2.55f)]
        [InlineData(new int[] { 2, 3, 2, 3 }, 2.50f)]
        [InlineData(new int[] { 3, 3, 3, 3, 3 }, 3.00f)]

        public void Mean_IntArray_Average(int[] numbers, float expected)
        {
            /// Act
            var result = _sut.Mean(numbers);
            /// Assert
            Assert.Equal(expected, result);
        }

    }
}
