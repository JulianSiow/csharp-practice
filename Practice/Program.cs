using System;

namespace Practice
{
    class Program
    {
        //Problem 2
        static string ConvertsToFahrenheit(double temp)
        {
            if (temp < -273.15)
            {
                return "Temperature below absolute zero!";
            }
            else
            {
                temp *= 9 / 5;
                temp += 32;
                return $"T = {temp}F";
            }
        }

        //Problem 3 Elementary Operations
        static string ElementaryOperations(double x, double y)
        {
            var add = x + y;
            var subtract = x - y;
            var mult = x * y;
            double divide;
            if (y != 0)
            {
                divide = x / y;
            }
            else
            {
                divide = 0;
            }

            return $"{add}, {subtract}, {mult}, {divide}";
        }

        //Problem 4 Is Result The Same
        static bool IsSame(double x, double y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //P5 Modulo Operations
        static double Modulo(double x, double y, double z)
        {
            return x % y % z;
        }

        //P6 Cube of
        static double Cube(double x)
        {
            return x * x * x;
        }

        // P7 Swap two numbers
        static string Swap(double x, double y)
        {
            string before = $"Before: x = {x}, y = {y} ";

            var temp = x;
            x = y;
            y = temp;

            string after = $"After: x = {x}, y = {y}";
            return before + after;
        }

        //Absolute Value
        static double AbsoluteVal(double num)
        {
            if (num > 0)
            {
                return num;
            }
            else
            {
                return num * -1;
            }
            // return number >= 0 ? number : number * -1;
        }

        //Divisible by 2 or 3
        static int DivisibleBy2or3(int x, int y)
        {
            if (x % 2 == 0 && y % 2 == 0 || x % 3 == 0 && y % 3 == 0)
            {
                return x * y;
            }
            else
            {
                return x + y;
            }
        }

        //If consists of uppercase letters
        //============================================= Come back to me ==========================================================
        static bool IsUppercase(string phrase)
        {
            return true;
        }

        //If Greater than third
        static bool IfGreaterThanThirdOne(int[] arr)
        {
            return arr[2] < arr[0] * arr[1] || arr[2] < arr[0] + arr[1];
        }

        //If number is even
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        //If Sorted Ascending
        static bool IsAscending(int[] arr)
        {
            return arr[0] < arr[1] && arr[1] < arr[2];
        }

        // If has neighbor
        //============================================== Come Back ================================================================
        static bool HasNeighbor(string letters)
        {
            return true;
        }

        // Positive, Negative or Zero
        static string PositiveNegativeZero(double num)
        {
            if (num > 0.0)
            {
                return "positive";
            }
            else if (num < 0.0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }

        //If year is leap
        static bool IsLeap(int year)
        {
            if (year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        //Contains 3
        static bool Contains3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        //Multiplication table
        static string PrintMultTable()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return "come back to me";
        }

        //Fractions sum
        static double FractionSum(int num)
        {
            double sum = 0.0;
            for (int i = 1; i <= num; i++)
            {
                sum += (1 / (double)(i * i));
            }

            return sum;
        }

        //Sort ascending
        static int[] SortAscending(int[] arr)
        {
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

        //The biggest number
        static int Biggest(int[] arr)
        {
            int biggest = arr[0];
            foreach (int num in arr)
            {
                if (num > biggest)
                {
                    biggest = num;
                }
            }
            return biggest;
        }

        //Two sevens
        static int TwoSevens(int[] arr)
        {
            int numOfPairs = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    numOfPairs++;
                }
            }
            return numOfPairs;
        }

        //Three increasing adjacent
        static bool ThreeIncreasing(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] + 1 == arr[i + 1] && arr[i] + 2 == arr[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        //Return Even
        static string ReturnEvens()
        {
            int i = 1;
            string str = "";
            while (i < 100)
            {
                if (i % 2 == 0)
                {
                    str += $"{i} ";
                }
                i++;
            }
            return str;
        }

        //Sieve of Eratosthenes
        //================================================================ come back ===============================================================
        static bool Sieve(int num)
        {
            int i = 2;
            while (i < num)
            {

            }
            return false;
        }

        static string ExtractString(string str)
        {
            string extractedStr = "";
            bool start = false;
            bool end = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '#' && str[i + 1] != '#' && start == false)
                {
                    start = true;
                }
                else if (str[i] != '#' && start == true && end == false)
                {
                    extractedStr += str[i];
                }
                else if (str[i] == '#' && start == true)
                {
                    end = true;
                }
            }
            if (start && end && extractedStr.Length > 1)
            {
                return extractedStr;
            }
            else
            {
                return "";
            }
        }

        //Full sequence of letters
        static string LetterSequence(string str)
        {
            string alph = "abcdefghijklmnopqrstuvwxyz";
            string sequence = "";
            bool start = false;
            for (int i = 0; i < alph.Length; i++)
            {
                if (alph[i] == str[1])
                {
                    sequence += alph[i];
                    return sequence;
                }
                else if (start == true)
                {
                    sequence += alph[i];
                }
                else if (alph[i] == str[0] && start == false)
                {
                    start = true;
                    sequence += alph[i];
                }
            }
            return sequence;
        }
        static void Main()
        {
            int[] arr = new int[6] { 9, 7, 3, 9, 10, 11 };
            Console.WriteLine(LetterSequence("or"));
        }

        //Longest strictly increasing sequence

    }
}
