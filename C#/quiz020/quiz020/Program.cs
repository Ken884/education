using System;

namespace quiz020
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
            if(age >= 0)
            {
                this.Age = age;
            }
        }


    }
}
