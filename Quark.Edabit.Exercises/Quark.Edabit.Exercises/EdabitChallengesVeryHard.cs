using System;
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
            if (sequenceLength < 2) return "invalid";

            List<string> FibonacciWords = new List<string> { "b", "a" };

            for (var i = 2; i < sequenceLength; i++)
            {
                FibonacciWords.Add(FibonacciWords[i - 1] + FibonacciWords[i - 2]);
            }

            string result = "";

            foreach (string FibonacciWord in FibonacciWords)
            {
                result += (result != "") ? ", " + FibonacciWord : FibonacciWord;
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
            Array.Resize<string>(ref splittedOtherPeopleNames, splittedOtherPeopleNames.Length + 1);
            splittedOtherPeopleNames[splittedOtherPeopleNames.Length - 1] = myName;
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

            return (regularPay + overtimePay).ToString("C", new CultureInfo("en-us"));
        }

        public bool CheckIfAnyKnightCanCapture(int[,] chessBoard)
        {
            bool canCapture = true;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (chessBoard[i, j] == 1)
                    {
                        int oneUp = i - 1;
                        int twoUp = i - 2;
                        int oneDown = i + 1;
                        int twoDown = i + 2;
                        int oneLeft = j - 1;
                        int twoLeft = j - 2;
                        int oneRight = j + 1;
                        int twoRight = j + 2;
                        if (i >= 1 && j >= 2)
                        {
                            if (CheckPosition(oneUp, twoLeft, chessBoard)) return false;
                        }
                        if (i >= 1 && j <= 5)
                        {
                            if (CheckPosition(oneUp, twoRight, chessBoard)) return false;
                        }
                        if (i <= 6 && j <= 5)
                        {
                            if (CheckPosition(oneDown, twoRight, chessBoard)) return false;
                        }
                        if (i <= 6 && j >= 2)
                        {
                            if (CheckPosition(oneDown, twoLeft, chessBoard)) return false;
                        }
                        if (i >= 2 && j <= 6)
                        {
                            if (CheckPosition(twoUp, oneRight, chessBoard)) return false;
                        }
                        if (i <= 5 && j <= 6)
                        {
                            if (CheckPosition(twoDown, oneRight, chessBoard)) return false;
                        }
                        if (i >= 2 && j >= 1)
                        {
                            if (CheckPosition(twoUp, oneLeft, chessBoard)) return false;
                        }
                        if (i <= 5 && j >= 1)
                        {
                            if (CheckPosition(twoDown, oneLeft, chessBoard)) return false;
                        }
                    }
                }
            }
            return canCapture;
        }

        public bool CheckPosition(int x, int y, int[,] chessBoard)
        {
            return (chessBoard[x, y] == 1);
        }

        public bool IsInDangerKnight(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (IsKnight(board[i, j]))
                    {
                        if (IsInDanger(i, j, board))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsInDanger(int row, int column, int[,] matrix)
        {
            var posiblePositions = PosibleEnemyPositions(row, column);
            for (int i = 0; i < posiblePositions.GetLength(0); i++)
            {
                try
                {
                    if (IsKnight(matrix[posiblePositions[i, 0], posiblePositions[i, 1]])) { return true; }
                }
                catch (Exception)
                {
                }
            }
            return false;
        }

        public int[,] PosibleEnemyPositions(int row, int col) => new[,] { { row + 2, col + 1 }, { row + 2, col - 1 }, { row - 2, col + 1 }, { row + 1, col - 2 }, { row - 2, col - 1 }, { row - 1, col - 2 }, { row + 1, col + 2 }, { row - 1, col + 2 } };

        private bool IsKnight(int n) => n == 1;

    }

}