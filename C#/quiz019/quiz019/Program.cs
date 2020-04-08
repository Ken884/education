using System;

namespace quiz019
{
    class Human
    {
        private string name;
        private int age;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
        static void Main(string[] args)
        {
            var hoge = new Human();
            hoge.name = "HOGE";
            hoge.age = 99;

            Console.WriteLine(hoge.GetName() + " , " + hoge.GetAge());
        }
    }
}
