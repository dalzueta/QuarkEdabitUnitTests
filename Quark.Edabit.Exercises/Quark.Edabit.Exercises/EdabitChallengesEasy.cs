using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Quark.Edabit.Exercises
{
    public class EdabitChallengesEasy
    {
        public bool Double_Letter(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        public string Stuttering(string word)
        {
            return word[0] + "" + word[1] + "... " + word[0] + word[1] + "... " + word;
        }

        public int Recursion_Sum(int num)
        {
            int total = 0;
            if (num > 0)
            {
                total = num + Recursion_Sum(num - 1);
            }
            return total;
        }

        public string Get_File_Name(string path) {
            int count = 0;
            bool flag = false;
            for (int i = path.Length-1; i >= 0 ; i--)
            {
                if (path[i] == '/') {
                    count = i;
                    flag = true;
                    break;
                }
            }
            return (!flag) ? path : path.Substring(count + 1);
        }

        public int Number_Greater_Than_A_B(int A, int B)
        {
            int num = A +1;
            while ((num < B) || (num % B != 0))
            {
                num += 1;
            }
            return num;
        }
        public string Reverse(string words)
        {
            string wordsReversed = "";
            for (int i= words.Length -1; i >= 0;  i --)
            {
                wordsReversed += words[i];
            }

            return wordsReversed;
        }

        public int[] NoOdds(int[] numbers)
        {
            List<int> numbersWithOutOdds = new List<int>(); 
            for (int i = 0; i< numbers.Length; i++)
            {
                if ( numbers[i] % 2 == 0)
                {
                    numbersWithOutOdds.Add(numbers[i]);
                }
            }

            return numbersWithOutOdds.ToArray();
        }

        public string ReverseCapitalize(string word)
        {
            string wordsReversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                wordsReversed += word[i];
            }

            return wordsReversed.ToUpper();
        }

        public string ModifyLast(string word, int repeatedLastCharacter)
        {
            for( int i = 0; i < repeatedLastCharacter -1; i++)
            {
                word += word[word.Length-1];
            }

            return word;
        }

        public int Search(int[] numbers, int item, int index)
        {
            if (index >= numbers.Length)
            {
                return -1;
            }
            else
            {
                if (numbers[index] == item)
                {
                    return index;
                }
                else
                {
                   return Search(numbers, item, index + 1);
                }
            }
        }

    }
}
