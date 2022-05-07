using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else 
            {
                return input.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
            }
            
        }
    }
}
