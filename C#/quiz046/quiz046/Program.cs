using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz046
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new LimitedList<string>(3) { };
            test.Add("hoge");
            test.Add("fuga");
            test.Add("bar");
            test.Add("foo");

            for(int x = 0; x < 3; x++)
            {
                Console.WriteLine(test.Get(x));
            }

        }
    }

    class LimitedList<T>
    {
        private List<T> list;
        private int maxCount = 0;

        public LimitedList(int maxCount)
        {
            list = new List<T>();
            this.maxCount = maxCount;
        }

        public void Add(T t)
        {
            if(list.Count() == maxCount)
            {
                list.RemoveAt(0);
                list.Add(t);
            }
            else
            {
                list.Add(t);
            }
        }

        public T Get(int i)
        {
            return list[i];
        }
    }
}
