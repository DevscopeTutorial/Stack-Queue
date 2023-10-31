using System.Collections;

namespace ReverseWordsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "This is a sample Text";
            string[] strArray = inputStr.Split(' ');
            foreach (string str in strArray)
            {
                ReverseWord(str);
            }
        }

        private static void ReverseWord(string str)
        {
            Stack stack = new Stack();
            foreach (char ch in str) 
            {
                stack.Push(ch);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.Write(' ');
        }
    }
}