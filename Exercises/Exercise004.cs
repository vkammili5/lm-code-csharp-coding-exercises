﻿using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();
            return dateTime.AddSeconds(Math.Pow(10,9));
        }
    }
}
