using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public static class SayedHelper
    {
        public static int Countnumber ( this string name)
        {
            char[] arr = name.ToArray<char>();
           return arr.Length;
        }

    }
}
