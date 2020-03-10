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

        //Longest strictly increasing sequence
        static int LongestStrictlyIncreasing(int[] arr)
        {
            int longest = 0;
            int currentCount = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] > arr[i])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 0;
                }
                if (currentCount > longest)
                {
                    longest = currentCount;
                }
            }
            return longest;
        }

        //Digit Sum
        static int DigitSum(int num)
        {
            int sum = 0;
            int x = 10;
            int y = 1;
            
            while(num / y >= 1)
            {
                sum += (num % x / y);
                x *= 10;
                y *= 10;
            }

            return sum;
        }

        //Sum and Average
        static string SumAndAverage(int lower, int higher)
        {
            int range = 0;
            int sum = 0;
            double avg = 0;

            for (int i = lower; i <= higher; i++)
            {
                sum += i;
                range++;
            }

            avg += sum / (double)range;
            return $"Sum: {sum}, Average: {avg}";
        }

        //Sum Double only
        static double SumDouble(object[] arr)
        {
            double sum = 0.0;

            foreach(object obj in arr)
            {
                if (obj is double)
                {
                    sum += (double)obj;
                }
            }

            return sum;
        }

        //Draw triangle
        static void DrawTriangle()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 10; k >= 10 - i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //To the power of
        static int PowerOf(int num, int power)
        {
            int raised = 1;
            if (power == 0)
            {
                return 1;
            }
            for (int i = 1; power > 0 ? i <= power : i <= power * (-1); i++)
            {
                raised *= num;
            }
            return raised > 0 ? raised : 1/raised;
        }

        //letter balance
        static bool LetterBalance(string letters)
        {
            bool isBalanced;
            for (int i = 0; i < letters.Length / 2; i++)
            {
                isBalanced = false;
                for (int j = letters.Length - 1; j >= letters.Length / 2; j--)
                {
                    if (letters[i] == letters[j])
                    {
                        isBalanced = true;
                    }
                }
                if (!isBalanced)
                {
                    return false;
                }
            }
            return true;
        }

        //Replace two words
        static string ReplaceWords(string words, char split)
        {
            int splitIndex = 0;
            string firstWord = "";
            string secWord = "";
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == split)
                {
                    splitIndex = i;
                }
            }
            for(int i = 0; i < splitIndex; i++)
            {
                firstWord += words[i];
            }
            for(int i = splitIndex + 1; i < words.Length; i++)
            {
                secWord += words[i];
            }
            return $"{secWord}{split}{firstWord}";
        }

        //Digital Root
        //??????????????????????????????????????????????

        //Check Brackets Sequence
        static bool CheckBrackets(string sequence)
        {
            int open = 0;
            int close = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                {
                    open++;
                }
                else if (sequence[i] == ')')
                {
                    close++;
                }
            }
            return open == close;
        }

        //Add Seperator
        static string AddSeperator(string word, char sep)
        {
            string newWord = string.Empty;
            for (int i=0; i<word.Length; i++)
            {
                if (i == word.Length - 1)
                {
                    newWord += word[i];
                }
                else
                {
                    newWord += $"{word[i]}{sep}";
                }
            }
            return newWord;
        }

        //Is Palindrome
        static bool IsPalindrome(string word)
        {
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return reversedWord == word;
        }

        static int LengthOfAString(string word)
        {
            int wordLength = 0;
            foreach(char letter in word)
            {
                wordLength++;
            }
            return wordLength;
        }

        //Reverse a string
        static string ReverseString(string word)
        {
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return reversedWord;
        }

        //Make odd letters uppercase
        static string MakeUppercase(string str)
        {
            int letterIndex = 0;
            string uppercaseStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' && letterIndex % 2 == 0)
                {
                    letterIndex++;
                    uppercaseStr += (char)(str[i] - 32);
                }
                else if (str[i] != ' ')
                {
                    letterIndex++;
                    uppercaseStr += str[i];
                }
                else
                {
                    letterIndex = 0;
                    uppercaseStr += str[i];
                }
            }
            return uppercaseStr;
        }

        //Mix two strings
        static string MixStrings(string str1, string str2)
        {
            string mixedStr = string.Empty;
            for(int i = 0; i < str1.Length || i < str2.Length; i++)
            {
                if (i >= str1.Length)
                {
                    mixedStr += str2[i];
                }
                else if (i >= str2.Length)
                {
                    mixedStr += str1[i];
                }
                else
                {
                    mixedStr += str1[i];
                    mixedStr += str2[i];
                }
            }
            return mixedStr;
        }

        //Number of words
        static int NumberOfWords(string sentance)
        {
            int wordCount = 1;
            foreach (char letter in sentance)
            {
                if (letter == ' ')
                {
                    wordCount++;
                }
            }
            return wordCount;
        }

        //Reverse word order
        static string ReverseOrder(string sentance)
        {
            int lastSpaceIndex = sentance.Length - 1;
            string reversedSentance = string.Empty;
            for (int i = sentance.Length - 1; i >= 0; i--)
            {
                if (char.IsWhiteSpace(sentance[i]))
                {
                    for (int j = i + 1; j <= lastSpaceIndex; j++)
                    {
                        reversedSentance += sentance[j];
                    }
                    lastSpaceIndex = i;
                    reversedSentance += ' ';
                }
                if (i == 0)
                {
                    for (int j = 0; j < lastSpaceIndex; j++)
                    {
                        reversedSentance += sentance[j];
                    }
                }
            }
            return reversedSentance;
        }

        //How many occurences
        static int HowManyOccurences(string phrase, string word)
        {
            int numberOfOccurences = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (i < phrase.Length - word.Length && phrase.Substring(i, word.Length) == word)
                {
                    numberOfOccurences++;
                }
            }
            return numberOfOccurences;
        }
        //Compress string
        static string CompressString(string str)
        {
            string compressedString = char.ToString(str[0]);
            char currentChar = str[0];
            int numberOfChar = 0;
            for (int i = 0; i<str.Length; i++)
            {
                if (currentChar == str[i])
                {
                    numberOfChar++;
                }
                else if (currentChar != str[i])
                {
                    currentChar = str[i];
                    compressedString += numberOfChar;
                    compressedString += currentChar;
                    numberOfChar = 1;
                }

            }
            compressedString += numberOfChar;
            return compressedString;
        }

        //Negative or positive
        static double NegativeOrPositive(double num)
        {
            return double.IsNegative(num) ? Math.Pow(num, 2) : Math.Sqrt(num);
        }
        static void Main()
        {
            object[] arr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
            Console.WriteLine(NegativeOrPositive(6.25));
        }
    }
}