using System;

namespace quiz022
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var me = new Human() { Name = "hayashi", Age = 25 };

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



    }
}