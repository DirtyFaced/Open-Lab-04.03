using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length < 2)
                return original;
            char[] arrayout = new char[original.Length - 2];
            for (int i = 1; i < original.Length - 1; i++)
            {
                arrayout[i - 1] = original[i];
            }
            string outt = new string(arrayout);
            return outt;
        }
    }
}
