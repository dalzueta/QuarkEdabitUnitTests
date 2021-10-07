﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

        public int TimeToGetLicense(string myName, int agentQuantity, string otherPeopleNames)
        {
            int timeToWait = 0;
            int agentWorkingCont = 1;
            string[] splittedOtherPeopleNames = otherPeopleNames.Split(" ");
            Array.Resize<string>(ref splittedOtherPeopleNames,splittedOtherPeopleNames.Length+1);
            splittedOtherPeopleNames[splittedOtherPeopleNames.Length-1] = myName;
            Array.Sort(splittedOtherPeopleNames);

            //Preguntar si es mejor usar un while o romper el for con un break
            foreach (string name in splittedOtherPeopleNames)
            {
                
                if (myName == name)
                {
                    timeToWait += 20;
                    break;
                }

                if (agentWorkingCont < agentQuantity)
                {
                    agentWorkingCont += 1;
                }
                else
                {
                    timeToWait += 20;
                    agentWorkingCont = 1;
                }

            }

            return timeToWait;
        }

        public string payCalculator(float[] workingDayValues)
        {

            float regularWorkingHours = 0;
            float overtimeWorkingHours = 0;

            if (workingDayValues[0] > 17 || workingDayValues[1] > 17)
            {
                overtimeWorkingHours = workingDayValues[1] - Math.Max(17, workingDayValues[0]);
                
            }

            if (workingDayValues[1] < 17 || workingDayValues[0] < 17)
            {
                regularWorkingHours = Math.Min(17, workingDayValues[1]) - workingDayValues[0];
            }
           
            float regularPay = regularWorkingHours * workingDayValues[2];
            float overtimePay = overtimeWorkingHours * workingDayValues[2] * workingDayValues[3];
            
            //refactorizar quitando regularPay y overtimePay?????????
             
            return (regularPay + overtimePay).ToString("C",new CultureInfo("en-us"));
        }
    }

}

