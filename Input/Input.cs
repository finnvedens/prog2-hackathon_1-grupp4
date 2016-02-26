using System;
using System.Collections.Generic;

namespace Input
{
    class Input
    {
        List<string> Keywords = new List<string>();

        public Input()
        {
            Keywords.Add("attack");
            Keywords.Add("search");
            Keywords.Add("left");
            Keywords.Add("right");
            Keywords.Add("forward");
        }

        public int getKeyword(string input)
        {
            List<string> Words = new List<string>();

            string a = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    Words.Add(a);
                    a = "";
                }
                else
                {
                    a += input[i];
                }
            }
            Words.Add(a);

            for (int i = 0; i < Keywords.Count; i++)
            {
                if (Words[0] == Keywords[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
