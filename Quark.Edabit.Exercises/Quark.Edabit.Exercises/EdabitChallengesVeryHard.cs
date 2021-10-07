using System;
using System.Collections.Generic;
using System.Text;

namespace Quark.Edabit.Exercises
{
    public class EdabitChallengesVeryHard
    {
        public bool IsAValidRondo(string sequence)
        {
            if (sequence.Length % 2 == 0 || sequence.Length < 3) return false;
            if (sequence[0] != 'A' || sequence[sequence.Length - 1] != 'A') return false;

            int auxValue = Convert.ToInt32(sequence[0]) - 1;

            foreach (char c in sequence)
            {
                if (c == 'A') continue;
                int charNumericValue = Convert.ToInt32(c);
                if (auxValue == charNumericValue - 1) auxValue = charNumericValue;
            }

            return true;
        }
        public string GetFibonacciWordSequence(int sequenceLength) 
        {
            if (sequenceLength < 2 ) return "invalid";

            List<string> FibonacciWords = new List<string> { "b", "a" };

            for (var i = 2; i < sequenceLength; i++)
            {
                FibonacciWords.Add(FibonacciWords[i-1] + FibonacciWords[i-2]);
            }

            string result = "";
            
            foreach (string FibonacciWord in FibonacciWords)
            {
                 result += (result != "") ? ", " + FibonacciWord : FibonacciWord ;
            }

            return result;
        }

        public string SimplifyFraction(string fraction)
        {
            string simplifiedFraction;
            string[] values = fraction.Split('/');
            int numerator = int.Parse(values[0]);
            int denominator = int.Parse(values[1]);
            bool wasSimplified = false;

            for (int i = 2; i < 6; i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    wasSimplified = true;
                }
            }

            if (wasSimplified)
            {
                simplifiedFraction = numerator.ToString() + "/" + denominator.ToString();
                simplifiedFraction = SimplifyFraction(simplifiedFraction);
            }
            else
            {
                simplifiedFraction = fraction;
            }

            return simplifiedFraction;
        }
    }

}

