using System;

namespace quiz023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var me = new Human();

            Console.WriteLine(me.Name);
            Console.WriteLine(me.Age);

        }
    }

    class Human
    {

        public string Name { get; set; } = "名無しの権兵衛";
        private int age = 25;
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