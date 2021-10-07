using System;
using System.Linq;

namespace Quark.Edabit.Exercises
{
    public class EdabitChallengesExpert
    {
        public bool palindromeDescendant(int number)
        {

            if (IsPalindromo(number))
            {
                return true;
            }
            else
            {
                if (number > 999)
                {
                    var a = ObtainNextChild(number.ToString());
                    if (palindromeDescendant(int.Parse(a))) return true;

                }
            }
            return false;
        }


        public string ObtainNextChild(string strNumber)
        {
            if (strNumber.Length < 3)
            {
                return SumNumbers(int.Parse(strNumber)).ToString();
            }
            else
            {
                var firstTwoValues = strNumber.Substring(0, 2);
                int sumTwoFirstValues = SumNumbers(int.Parse(firstTwoValues));

                return string.Join("", sumTwoFirstValues, ObtainNextChild(strNumber.Substring(2)));
            }
        }


        private bool IsPalindromo(int number)
        {
            var reverse = string.Join("", Math.Abs(number).ToString().Reverse());
            return number == int.Parse(reverse);
        }

        private string GetFirsTwoChars(ref string str)
        {
            var chars = str.Substring(0, 2);
            str = str.Substring(2);
            return chars;
        }

        private int SumNumbers(int num)
        {
            var unid = num / 10;
            var desc = num % 10;

            return unid + desc;

        }
    }
}
