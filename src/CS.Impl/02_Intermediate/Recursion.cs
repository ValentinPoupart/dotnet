using System;
using System.Collections.Generic;
using System.Linq;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            List<int> res = new List<int> { };
            if (n == 0)
                return res;
            else
            {
                res.Add(n);
                return GetNaturalNumbers(n - 1).Concat(res);
            }
        }

        public int SumNaturalNumbers(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + SumNaturalNumbers(n - 1);
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, n / 2);
        }

        private bool IsPrime(int n, int current)
        {
            if (current == 1)
            {
                return true;
            }
            else
            {
                if (n % current == 0)
                    return false;
                else
                    return IsPrime(n, current - 1);
            }
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}
