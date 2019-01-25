using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            var sentenceSplit = sentence.Split(' ');
            string res = "";
            foreach (string str in sentenceSplit)
            {
                res = res == "" ? $"{str}" : $"{str} {res}";
            }
            return res;
        }
    }
}
