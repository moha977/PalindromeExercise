using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
       
            public bool isAPalindrome(string text)
            {
            var result = Enumerable
             .SequenceEqual(text.ToLower().ToCharArray(), text.ToLower().ToCharArray()
             .Reverse());
            return result;
        }

        



    }

}
