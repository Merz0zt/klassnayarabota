namespace ConsoleApp21
{
    using System;
    using System.Collections.Generic;

    namespace Kata
    {
        public class CheckBracketBalance
        {
            public static bool IsBracketBalanced(string inputString)
            {
                Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

                Stack<char> bracketStack = new Stack<char>();

                foreach (char character in inputString)
                {
                    if (bracketPairs.ContainsKey(character))
                    {
                        bracketStack.Push(character);
                    }
                    else if (bracketPairs.ContainsValue(character))
                    {
                        if (bracketStack.Count == 0 || bracketPairs[bracketStack.Pop()] != character)
                        {
                            return false;
                        }
                    }
                }

                return bracketStack.Count == 0;
            }
        }
    }
}