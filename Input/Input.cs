using System;
using System.Collections.Generic;
/*I made this change*/
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
			string word = "";
            for(int i = 0; i < input.Length; i++) 
			{
				if(input[i] == ' ') {
					word = input.Substring(i - 1);
					break;
				}
				else-if(i == input.Length - 1) {
					word = input;
					break;
				}
			}

            for (int i = 0; i < Keywords.Count; i++)
            {
                if (word == Keywords[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
