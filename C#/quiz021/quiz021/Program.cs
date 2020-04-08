using System;

namespace quiz021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human someone = new Human("Someone", 58);

            Console.WriteLine(someone.Name);
            Console.WriteLine(someone.Age);

            someone.Name = "Something";
            someone.Age = 50;

            Console.WriteLine(someone.Age);
            Console.WriteLine(someone.Name);

            Human me = new Human("me", 0);
            me.Name = "hayashi";
            me.Age = 25;
            Console.WriteLine(me.Name);
            Console.WriteLine(me.Age);

        }
    }

    class Human
    {

        public string Name { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }

        public Human(string name, int age)
        {
            this.Name = name;
            if (age >= 0)
            {
                this.Age = age;
            }
        }


    }
}