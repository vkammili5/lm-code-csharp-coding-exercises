using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return Math.Round(originalPrice + (originalPrice * vatRate / 100), 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            char[] senArray = sentence.ToCharArray();
            Array.Reverse(senArray);
            string revString = new string(senArray);
            return revString;
            
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            int LinuxCount=0;
            foreach(User u in users)
            {
                if (u.Type == "Linux")
                {
                    LinuxCount = LinuxCount + 1;
                    
                }
            }
            return LinuxCount;
        }
    }
}
