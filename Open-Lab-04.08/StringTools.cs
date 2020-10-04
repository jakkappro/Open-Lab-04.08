using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> ret = new List<string>();
            foreach(string s in strings)
            {
                if(s.Length == 4)
                {
                    ret.Add(s);
                }
            }
            return ret.ToArray();
        }
    }
}
