using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task.Models
{
    internal static class ExtensionMethods
    {
        public static bool CustomContains(this string word, string searcWord )
        {
            if(word.Contains(searcWord))
            {
                return true;
            }
            return false;
        }

        public static bool CustomContains(this string word, char letter)
        {
            if (word.Contains(letter))
            {
                return true;
            }
            return false;
        }

        public static bool IsPrime(this int number)
        {
            if (number > 1)
            {
                int count = 2;
                for (int i = 2; i < number; i++)
                {
                    if(number%i == 0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool IsPowOfTwo(this int number)
        {
            while(number > 1)
            {
                if(number%2 == 0)
                {
                    number/=2;
                }
                else
                {
                    break;
                }
            }
            if(number==1)
            {
                return true;
            }
            return false;
        }
    }
}