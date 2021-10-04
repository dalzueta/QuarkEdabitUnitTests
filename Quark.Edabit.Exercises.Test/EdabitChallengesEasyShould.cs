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

        //// 
        //[Theory]
        //[InlineData(2, 3, 5)]
        //[InlineData(-3, 6, 3)]
        //[InlineData(3, 7, 10)]
        //[InlineData(0.3, 0.7, 1)]
        //public void SumTwoNumbers(double number1, double number2, double expected)
        //{
        //    /// Act
        //    //var result = _sut.SubTwoNumbers(number1, number2);
        //    /// Assert
        //    //Assert.Equal(expected, result);
        //}


        // Double_Letter
        [Theory]
        [InlineData("loop", true)]
        [InlineData("yummy", true)]
        [InlineData("orange", false)]
        [InlineData("munchkin", false)]
        public void Double_Letter(string arg, bool expected)
        {
            /// Act
            var result = _sut.Double_Letter(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Stuttering 
        [Theory]
        [InlineData("loop", "lo... lo... loop")]
        [InlineData("yummy", "yu... yu... yummy")]
        [InlineData("orange", "or... or... orange")]
        [InlineData("munchkin", "mu... mu... munchkin")]
        public void Stuttering(string arg, string expected)
        {
            /// Act
            var result = _sut.Stuttering(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Recursion_Sum 
        [Theory]
        [InlineData(5, 15)]
        [InlineData(1, 1)]
        [InlineData(12, 78)]
        public void Recursion_Sum(int arg, int expected)
        {
            /// Act
            var result = _sut.Recursion_Sum(arg);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // File Name
        [Theory]
        [InlineData("C:/Projects/pil_tests/ascii/edabit.txt", "edabit.txt")]
        [InlineData("C:/Users/johnsmith/Music/Beethoven_5.mp3", "Beethoven_5.mp3")]
        [InlineData("ffprobe.exe", "ffprobe.exe")]
        public void Get_File_Name(string path, string expected)
        {
            /// Act
            var result = _sut.Get_File_Name(path);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Next Number Greater Than A and B and...
        [Theory]
        [InlineData(17, 8, 24)]
        [InlineData(93, 3, 96)]
        [InlineData(14, 11, 22)]
        public void Number_Greater_Than_A_B(int a, int b, int expected)
        {
            /// Act
            var result = _sut.Number_Greater_Than_A_B(a, b);
            /// Assert 
            Assert.Equal(expected, result);
        }

        // Reverse the order of a string
        [Theory]
        [InlineData("Hello World","dlroW olleH")]
        [InlineData("The quick brown fox.", ".xof nworb kciuq ehT")]
        [InlineData("Edabit is really helpful", "!lufpleh yllaer si tibadE")]
        public void Reverse(string words, string expected)
        {
            /// Act
            var result = _sut.Reverse(words);
            /// Assert 
            Assert.Equal(expected, result);
        }

    }
}
