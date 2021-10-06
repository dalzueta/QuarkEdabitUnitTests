using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.RegularExpressions;
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

        public string Greeting(string name)
        {
            if (name == "Mubashir")
            {
                return "Hello, my Love!";
            }

            return "Hello, " + name + "!";
        }

        public float InchesToFeet(float inches)
        {
            return inches / 12;
        }

        public int SumPolygon(int sides)
        {
            return (sides - 2) * 180;
        }

        public bool DivisibleByFive(int number)
        {
            return (number % 5 == 0);
        }
        public int Squared(int a)
        {
            return a * a;
        }

        public int FlipIntBool(int number)
        {
            return (number == 1) ? 0 : 1;
        }

        public bool DividesEvenly(int number1, int number2)
        {
            return (number1 % number2 == 0);
        }

        public int Frames(int minutes, int fps)
        {
            return minutes * 60 * fps;
        }

        public bool ProfitableGamble(double prob, double prize, double pay)
        {
            return prob * prize > pay;

        }

        public bool Divisible(int number)
        {
            return (number % 100 == 0);
        }

        public bool Date_Chrismas_Eve(int month, int date)
        {
            return month == 12 && date == 24;
        }

        public int Nth_Even_Number(int arg)
        {
            return (arg + arg) - 2;
        }

        public int Negative_Number(int arg)
        {
            if(arg <= 0) return arg;

            return arg*(-1);
        }

        public int Methods_ABS(int arg)
        {
            if(arg >= 0) return arg;

            return arg*(-1);
        }

        public double Coffee_Cup(double arg)
        {
            return Math.Truncate((arg/6)) + arg; 
        }

        public int Stack_The_Boxes(int arg)
        {
            return (int) Math.Pow(arg, 2); 
        }
        public int[] Buggy_Code_Part5(int arg)
        {
            int[] result = new int[arg];
            for (int i = 0; i < arg; i++)
            {
                result[i] = i+1;
            }
            return result;
        }

        public string Concatenate_First_And_Last_Name(string first, string last)
        {
            return last + ", " + first;
        }

        public bool Drinks_Allowed(int age, bool breakBarman)
        {
            return age >= 18 && !breakBarman;
        }

        public bool String_Empty(string arg)
        {
            return string.IsNullOrEmpty(arg);
        }

        public bool Comp(string str1, string str2)
        {
            return (str1.Length == str2.Length);
        }

        public int Area(int side1, int side2)
        {
            if (side1 < 1 || side2 < 1) return -1;
            else return side1 * side2;
        }

        public bool OddOrEven(string str)
        {
            return (str.Length % 2 == 0);
        }

        public string IsEvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        public int Length(string word)
        {
            if (word == "") return 0;
            word = word.Remove(0, 1);
            return 1 + Length(word);
        }
    }
}
