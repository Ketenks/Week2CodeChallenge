using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALLING FUNCTIONS
            Console.WriteLine("CALLING FUNCTIONS********");
            Console.WriteLine();

            Console.WriteLine("FIZZBUZZ\n");

            for (int i = 1; i < 21; i++)
            {
                FizzBuzz(i);
            }

            Console.WriteLine();
            Console.WriteLine("LETTERCOUNTER\n");

            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            Console.WriteLine("TEXTSTATS\n");

            TextStats("The fundamental principle of fundamental principles is absolute truth.\n" +
            "For how then could something be applied across a group? Relative truth then,\n" +
            "is the difference of the applications of two principles.");

            //keeps console open
            Console.ReadKey();
        }
        //BEGIN FUNCTION DECLARATION

        //writing specific output for specific input on the basis of divisibility
        //i. If the number is divisible by 5, print out “Fizz”
        //ii. If the number is divisible by 3, print out “Buzz”
        //iii. If the number is divisible by 5 and 3, print out “FizzBuzz”
        //iv. If the number is not divisable by 5 and 3, print out the number
        static void FizzBuzz(int number)
        {
            if (number == 0)
            {
                Console.WriteLine(number);
            }
            else if ((number % 5 == 0) && (number % 3 == 0))
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
            
        }

       /* i. Using the letter parameter, search the inString for the number of instances of 
 that letter in the string. 
 ii. Your code must look for both UPPERCASE and lowercase instances of 
 the letter.
 iii. Your LetterCounter will produce the following output:
 Input: <the inString>
 Number of lowercase <letter>s found: X
 Number of UPPERCASE <letter>s found: Y
 Total Number of <letter>s found: Z*/
        static void LetterCounter(char letter, string inString)
        {
            //declare function variables
            int lowCount = 0;
            int upCount = 0;

            //for loop and conditions to check and count letter instances
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i] == (char.ToLower(letter)))
                {
                    lowCount++;
                }
                else if (inString[i] == (char.ToUpper(letter)))
                {
                    upCount++;
                }
            }
            //add them together
            int total = lowCount + upCount;

            //write the output  to the console
            Console.WriteLine("Input: " + inString +
                "\n" + "Number of lowercase " + letter + "'s found: " + lowCount +
                "\n" + "Number of UPPERCASE " + letter + "'s found: " + upCount +
                "\n" + "Total Number of " + letter + "'s found: " + total);
            Console.WriteLine();
        }

        //This function will process a string and print out the following information:
        //i. Number of characters: X
        //ii. Number of words: X
        //iii. Number of vowels: X
        //iv. Number of consonants : X
        //vi. Longest Word: XXXXXX
        //vii. Shortest Word: XX
        static void TextStats(string input)
        {

            //declare function variables

            List<string> inputListWords = input.Trim(new Char[] { ' ' }).Replace("`", "").Replace("~", "").Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("^", "").Replace("&", "").Replace("*", "").Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace("=", "").Replace("+", "").Replace("\\", "").Replace("|", "").Replace("]", "").Replace("}", "").Replace("[", "").Replace("{", "").Replace(";", "").Replace(":", "").Replace("/", "").Replace("?", "").Replace(".", "").Replace(">", "").Replace(",", "").Replace("<", "").Split(' ').ToList();
            int vowelNum = 0;
            int consonantNum = 0;
            int specialCharNum = 0;
            //string longestWord = "";
            List<string> longestWordList = new List<string> { };
            //string secondLongestWord = "";
            List<string> secondLongestWordList = new List<string> { };
           // string shortestWord = "                                                  ";
            List<string> shortestWordList = new List<string> { };
            string temp = " ";
            List<string> holdingTank = new List<string> { };

            //for loop to print longest word, shortest word
            for (int i = 0; i < inputListWords.Count; i++)
            {
                for (int j = 1; j < inputListWords.Count; j++)
                {
                    if (inputListWords[i].Length < inputListWords[j].Length)
                    {
                        temp = inputListWords[i];
                        inputListWords[i] = inputListWords[j];
                        inputListWords[j] = temp;
                    }
                }
                holdingTank.Add(temp);
            }
            for (int i = 0; i < holdingTank.Count; i++)
            {
                if (holdingTank[0].Length == holdingTank[i].Length && holdingTank[0] != holdingTank[i])
                {
                    longestWordList.Add(holdingTank[i] + ", ");
                }
            }



            //for loop to print number of: characters, words, vowels, consonants, and special characters
            for (int i = 0; i < input.Length; i += 1)
            {
                char inputLetter = input[i];

                if (inputLetter == '`' || inputLetter == '~' || inputLetter == '!' || inputLetter == '@' || inputLetter == '#' || inputLetter == '$' || inputLetter == '%' || inputLetter == '^' || inputLetter == '&' || inputLetter == '*' || inputLetter == '(' || inputLetter == ')' || inputLetter == '-' || inputLetter == '_' || inputLetter == '=' || inputLetter == '+' || inputLetter == '[' || inputLetter == '{' || inputLetter == ']' || inputLetter == '}' || inputLetter == '\'' || inputLetter == ';' || inputLetter == ':' || inputLetter == '"' || inputLetter == '\\' || inputLetter == ',' || inputLetter == '<' || inputLetter == '.' || inputLetter == '>' || inputLetter == '/' || inputLetter == '?' || inputLetter == '|')
                {
                    specialCharNum++;
                }


                if (inputLetter == 'b' || inputLetter == 'c' || inputLetter == 'd' || inputLetter == 'f' || inputLetter == 'g' || inputLetter == 'h' || inputLetter == 'j' || inputLetter == 'k' || inputLetter == 'l' || inputLetter == 'm' || inputLetter == 'n' || inputLetter == 'p' || inputLetter == 'q' || inputLetter == 'r' || inputLetter == 's' || inputLetter == 't' || inputLetter == 'v' || inputLetter == 'w' || inputLetter == 'x' || inputLetter == 'y' || inputLetter == 'z')
                {
                    consonantNum++;
                }

                if (inputLetter == 'a' || inputLetter == 'e' || inputLetter == 'i' || inputLetter == 'o' || inputLetter == 'u' || inputLetter == 'y')
                {
                    vowelNum++;
                }
            }

            //writing each assignment to the console
            /*for (int i = 0; i < inputListWords.Count; i++)
            {
                Console.WriteLine(inputListWords[i]);
            }*/
            Console.WriteLine("i. Number of characters: " + input.Length);
            Console.WriteLine("ii. Number of words: " + inputListWords.Count);
            Console.WriteLine("iii. Number of vowels: " + vowelNum);
            Console.WriteLine("iv. Number of consonants: " + consonantNum);
            Console.WriteLine("v. Number of special characters: " + specialCharNum);
            //write that stupid dang EC all in one line
            Console.Write("E.C. Longest word: ");
            for (int i = 0; i < longestWordList.Count; i++)
            {
                Console.Write(longestWordList[i]);
            }
           /* Console.Write(" | " + "Second Longest Word: ");
            for (int i = 0; i < secondLongestWordList.Count; i++)
            {
                Console.Write(secondLongestWordList[i]);
            }*/
            Console.Write(" | " + "Shortest Word: ");
            for (int i = 0; i < shortestWordList.Count; i++)
            {
                Console.Write(shortestWordList[i]);
            }
            Console.WriteLine("\n");


        }
    }
}
