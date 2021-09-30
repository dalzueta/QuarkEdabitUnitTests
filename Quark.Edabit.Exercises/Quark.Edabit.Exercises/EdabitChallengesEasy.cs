using System;
using System.Collections.Generic;
using System.Text;

namespace Quark.Edabit.Exercises
{
    public class EdabitChallengesEasy
    {
        public double CalculateExponent(int number1, int number2)
        {
            return Math.Pow(number1, number2);
        }

        public int[] MultiplyByLength(int[] arrayNumbers)
        {
            int[] newArray = new int[arrayNumbers.Length];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                newArray[i] = arrayNumbers[i] * arrayNumbers.Length;
            }

            return newArray;
        }

        public int HammerDistance(string firstString, string secondString)
        {
            int differenceQuantity = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {
                    differenceQuantity += 1;
                }
            }

            return differenceQuantity;
        }

        public string NameShaffle(string firstAndLastName)
        {
            string[] splittedName = firstAndLastName.Split(' ');

            return splittedName[1] + " " + splittedName[0];
        }

        public string SmallerNum(string firstNumber, string secondNumber)
        {
            return (Int32.Parse(firstNumber) < Int32.Parse(secondNumber)) ? firstNumber : secondNumber;
        }

        public bool SameCase(string word)
        {
            return (word == word.ToLower() || word == word.ToUpper());
        }

        public int CountDs(string phrase)
        {
            int dsCount = 0;
            phrase = phrase.ToLower();

            foreach(char letter in phrase)
            {
                if(letter == 'd') dsCount++;
            }

            return dsCount;
        }

        public string NSidedShape(int sides)
        {
            string[] shapes = {"circle", "semi-circle", "triangle", "Square", "pentagon",
                               "hexagon","heptagon", "octagon", "nonagon", "decagon"};

            return shapes[sides - 1];
        }

        public int CountClaps(string claps)
        {
            string[] clapArray = claps.Split('C');

            return clapArray.Length - 1;
        }

        public string LongBurp(int numberOfRs)
        {
            string burp = "Bu";
            for(int i=0; i < numberOfRs; i++)
            {
                burp += "r";
            }
            burp += "p";

            return burp;
        }
    }
}
