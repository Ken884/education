using System;
using System.Linq;

namespace quiz009
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            Console.WriteLine(test.Palindrome("よのなかねかおかおかねかなのよ"));
        }

        public bool Palindrome(string pali){
            string rev = new string(pali.Reverse().ToArray());
            
            return rev == pali;
        }
    }
}
