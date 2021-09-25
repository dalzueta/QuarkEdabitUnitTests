using System;

namespace Quark.Edabit.Exercises
{
    public class EdabitChallengesVeryEasy
    {
        // Return the Sum of Two Numbers 
        public double SubTwoNumbers(double number1, double number2)
        {
            return number1 + number2;
        }

        // Is the Number Less than or Equal to Zero?
        public bool LessThanOrEqualToZero(double a)
        {
            return a <= 0;
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
