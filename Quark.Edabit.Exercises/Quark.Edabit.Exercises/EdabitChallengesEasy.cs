using System;
using System.Collections.Generic;
using System.Linq;
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

        public int Factorial(int number)
        {
            if (number > 1) number *= Factorial(number - 1);

            return number;
        }

        public int CountVowels(string phrase)
        {
            int vowelsCount = 0;
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (char c in phrase)
            {
                if (vowels.Contains(c))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }

        public int[] SortNumsAscending(int[] array)
        {
            if (array == null) array = new int[] { };
            Array.Sort(array);
            return array;
        }

        public bool IsIdentical(string phrase)
        {
            char pivot = phrase[0];

            foreach (char c in phrase)
            {
                if (c != pivot) return false;
            }

            return true;
        }

        public string HackerSpeak(string phrase)
        {
            string translatedString = "";
            Dictionary<char, int> hackerDict = new Dictionary<char, int>
            {
                {'a', 4 },
                {'e', 3 },
                {'i', 1 },
                {'s', 5 },
                {'o', 0 }
            };

            foreach (char c in phrase)
            {
                if (hackerDict.ContainsKey(c))
                {
                    translatedString += hackerDict[c].ToString();
                }
                else
                {
                    translatedString += c.ToString();
                }
            }

            return translatedString;
        }

        public bool SameCase(string word)
        {
            return (word == word.ToLower() || word == word.ToUpper());
        }

        public int CountDs(string phrase)
        {
            int dsCount = 0;
            phrase = phrase.ToLower();

            foreach (char letter in phrase)
            {
                if (letter == 'd') dsCount++;
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
            for (int i = 0; i < numberOfRs; i++)
            {
                burp += "r";
            }
            burp += "p";

            return burp;
        }

        public string RemoveFirstLast(string phrase)
        {
            if (phrase.Length <= 2) return phrase;
            var sb = new System.Text.StringBuilder();
            sb.Append(phrase);
            sb.Remove(0, 1);
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public string FormatDate(string date)
        {
            string[] dateParts = date.Split('/');

            return dateParts[2] + dateParts[1] + dateParts[0];
        }

        public string FizzBuzz(int number)
        {

            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                {
                    return "FizzBuzz";
                }
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        public string Repetition(string phrase, int times)
        {
            if (times > 1)
            {
                phrase += Repetition(phrase, times - 1);
            }
            return phrase;
        }

        public string DoubleChar(string phrase)
        {
            string newPhrase = "";
            foreach (char c in phrase)
            {
                string _c = c.ToString();
                newPhrase += _c + _c;
            }
            return newPhrase;
        }

        public int[] HashPlusCount(string str)
        {
            int[] result = new int[2];

            char[] chars = str.ToCharArray();

            str.ToList().ForEach(
                x =>
                {
                    if (x == '#')
                    {
                        ++result[0];
                    }
                    else
                    {
                        ++result[1];
                    }
                }
            );

            return result;
        }

        public string FormatPhoneNumber(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }

        public object Repeat(string str, int count)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += new String(str[i], count);
            }

            return result;
        }

        public object SpaceMeOut(string str)
        {
            string result = str[0].ToString();

            for (int i = 1; i < str.Length; i++)
            {
                result += " " + str[i];
            }

            return result;

        }

        public float Mean(int[] numbers)
        {
            float avg = (float)Queryable.Average(numbers.AsQueryable());
            string a = avg.ToString("f2");

            return float.Parse(a);
        }

        public string GetWord(string str1, string str2)
        {
            StringBuilder result = new StringBuilder(str1 + str2);

            result[0] = result[0].ToString().ToUpper()[0];

            return result.ToString();
        }

        public string[] IsFourLetters(string[] str)
        {
            List<string> result = new List<string>();

            str.ToList<string>().ForEach(_str =>
            {
                if (_str.Length == 4) result.Add(_str);
            });

            return result.ToArray<string>();
        }

        public bool XO(string str)
        {
            str = str.ToLower();
            int currentXAmount = 0;
            int currentOAmount = 0;
            str.ToList().ForEach( c =>
            {
                if (c == 'x') currentXAmount++;
                if (c == 'o') currentOAmount++;
            });

            return (currentXAmount == currentOAmount) ? true : false;
        }

        public string AlphabetSoup(string str)
        {
            char[] charX = str.ToCharArray();

            StringBuilder result = new StringBuilder();

            Array.Sort(charX);

            charX.ToList().ForEach(c =>
            {
                result.Append(c);
            });

            return result.ToString();
        }

        public int Algorithms1_IntroductionToRecursion(int num)
        {
            int result = 1;
            if (num > 0)
            {
                result = num * Algorithms1_IntroductionToRecursion(num - 1);
            }
            return result;            
        }

        public bool Between_Words(string first, string last, string word)
        {
            char[] numsOfFirst = first.ToCharArray();
            char[] numsOfLast = last.ToCharArray();
            char[] numsOfWord = word.ToCharArray();

            int valFirst = 0;
            int valLast = 0;
            int valWord = 0;

            for (int i = 0; i < numsOfFirst.Length; i++)
            {
                valFirst += numsOfFirst[i];
            }
            for (int i = 0; i < numsOfLast.Length; i++)
            {
                valLast += numsOfLast[i];
            }
            for(int i = 0; i < numsOfWord.Length; i++)
            {
                valWord += numsOfWord[i];
            }

            return valWord > valFirst && valWord < valLast;
        }

        public bool Is_Palindrome_Word(string word)
        {            
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[(word.Length-1)-i])
                {
                    return false;
                }
            }
            return true;
        }

        public string Vowel_Replacer(string word, char character)
        {
            StringBuilder result = new StringBuilder(word);

            result.Replace('a', character);
            result.Replace('e', character);
            result.Replace('i', character);
            result.Replace('o', character);
            result.Replace('u', character);

            return result.ToString();
        }

        public object Remove_Duplicates_From_Array(object[] _var)
        {
            List<object> auxList = _var.ToList();
            List<object> result = new List<object>();
            while (auxList.Count > 0)
            {
                if (!result.Contains(auxList[0]))
                    result.Add(auxList[0]);
                auxList.RemoveAll(x => x == auxList[0]);
            }
            return result.ToArray<object>();
        }

        //public int Equal(int first, int second, int third)
        //{
        //    List<int> numbers = new List<int>() { first, second, third };
        //    List<int> auxlist = new List<int>();
        //    int count = 0;
        //    numbers.ForEach(n =>
        //    {
        //        if (!auxlist.Contains(n))
        //        {
        //            auxlist.Add(n);
        //            numbers.ForEach(r =>
        //            {
        //                if (r == n) count++;
        //            });
        //        }
        //    });

        //    return count;
        //}
    }
}
