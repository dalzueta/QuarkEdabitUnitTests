using System;

namespace Quark.Edabit.Exercises
{
    public class EdabitChallengesVeryEasy
    {
        //Return the sum of two numbers
        public int Sum(int a, int b)
        {
            return a + b;
        }
        //Convert minutes into seconds
        public int ConvertMinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }
        //Return the next number from the int passed
        public int AddOne(int a)
        {
            return a + 1;
        }
        //PowerCalculator
        public int CalculateElectricalPower(int voltage, int current)
        {
            return voltage * current;
        }
        //Convert Age to Days
        public int CalcAge(int age)
        {
            return age * 365;
        }
        //Area of a Triangle
        public int TriArea(int tBase, int height)
        {
            return (tBase * height) / 2;
        }

        //Return the remainder from two numbers
        public int Remainder(int a, int b)
        {
            return a % b;
        }

        //Is the number less than or equal to zero?
        public bool LessThanOrEqualToZero(int a)
        {
            return a <= 0;
        }

        //Less than 100
        public bool LessThan100(int a, int b)
        {
            return a + b < 100;
        }

        //Are the numbers equal?
        public bool IsEqual(int a, int b)
        {
            return a == b;
        }

        // Return Something to Me!
        public object GiveMeSomething(string arg)
        {
            return "something " + arg;
        }

        public bool Reverse(bool arg)
        {
            return !arg;
        }

        public double HowManySeconds(double hours)
        {
            return hours * 3600;
        }

        public string NameString(string arg)
        {
            string result = arg + "Edabit";
            return result;
        }

        public object And(bool firstArg, bool secondArg)
        {
            return firstArg && secondArg;
        }

        public int Points(int doublesPoints, int triplesPoints)
        {
            return doublesPoints * 2 + triplesPoints * 3;
        }

        public int FindPerimeter(int length, int width)
        {
            return 2 * (length + width);
        }

        public string HelloName(string name)
        {
            return "Hello " + name + "!";
        }

        public int Animals(int chickens, int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4;
        }

        public object FootballPoints(int wins, int draws, int losses)
        {
            return wins * 3 + draws * 1 + losses * 0;
        }
    }
}
