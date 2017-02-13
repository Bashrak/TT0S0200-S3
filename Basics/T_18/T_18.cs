using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_18
{
    class T_18
    {
        static void Main(string[] args)
        {
            Console.Write("Give a sentence: ");
            string sentence = Console.ReadLine();
            string sentenceClone = sentence;
            sentence = sentence.Replace(" ", String.Empty);
            Console.WriteLine(sentence);
            if (PalindromeCheck(sentence))
            {
                Console.WriteLine("{0} It is a palindrome!", sentenceClone);
            }
            else
            {
                Console.WriteLine("{0} It is not a palindrome", sentenceClone);
            }
        }

        static bool PalindromeCheck(string sentence)
        {
            bool palindrome = true;

            for (int i = 0; i < sentence.Length / 2 + 1; i++)
            {
                if (sentence.ToLower()[i] != sentence.ToLower()[sentence.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }

            return palindrome;
        }
    }
}
