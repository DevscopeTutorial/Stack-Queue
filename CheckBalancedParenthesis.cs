using System.Collections;

namespace CheckBaalancedParenteses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String expr = "({[]})";
            if (isExpressionBalanced(expr))
            {
                Console.WriteLine(expr + " => Balanced" );
            }
            else 
            {
                Console.WriteLine(expr + " => Not Balanced");
            }
        }

        private static bool isExpressionBalanced(string expr)
        {
            Stack stack = new Stack();
            foreach (char current in expr)
            {
                if (stack.Count > 0 && isSameKind((char)stack.Peek(), current))
                {
                    //Pop top element
                    stack.Pop();
                }
                else 
                {
                    //Push current bracket
                    stack.Push(current); 
                }
            }

            
            if(stack.Count>0)
                return false;
            else
                return true;
        }

        private static bool isSameKind(char first, char second)
        {
            if (first == '[' && second == ']' || first == '{' && second == '}' || first == '(' && second == ')')
            {
                return true;
            }
            return false;
        }
    }
}