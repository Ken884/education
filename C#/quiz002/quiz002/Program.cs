using System;

namespace quiz002
{
    class Human
    {
        private string name;
        private int age;
        private bool home;

     

        static void Main(string[] args)
        {
            Human watashi = new Human();
            watashi.IntroduceMyself("Ken", 25, false);
        }

        public void IntroduceMyself(string name, int age, bool home)
        {
            
            if (home == true)
            {
                Console.WriteLine("I am " + name + "," + age + "years old, live with my family.");;
            }
            else
            {
                Console.WriteLine("I am " + name + ", " + age + "years old, live alone");
            }

        }

    }
}
