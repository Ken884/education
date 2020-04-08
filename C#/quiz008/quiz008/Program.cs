using System;
using System.Text.RegularExpressions;


namespace quiz008

{
    class Program 
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            Console.WriteLine(test.IsPresident("遅越　彰  "));
        }

        public bool IsPresident(string name)
        {
            bool judge;
            name = name.TrimStart().TrimEnd();
            Console.WriteLine(name);
            if(Regex.IsMatch(name, "^遅越　彰") || Regex.IsMatch(name, "^遅越彰"))
            {
                judge = true;
            }
            else
            {
                judge = false;
            }
            return judge;
        }
    }
}
