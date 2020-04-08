using System;
using System.Collections.Generic;

namespace quiz025
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            Console.WriteLine("VOLUME " + tv.Volume);
            Console.WriteLine(tv.Channel + " Ch");

            tv.Channel = 7;
            Console.WriteLine(tv.Channel + " Ch");

            tv.VolumeUp();
            tv.VolumeUp();
            tv.ChannelBack();

            Console.WriteLine("VOLUME " + tv.Volume);
            Console.WriteLine(tv.Channel + " Ch");

            tv.ShowStation();
        }
    }

    class TV
    {
        private int volume;
        public int Volume { get; private set; } = 10;
        private int channel = 1;
        public int Channel
        {
            get
            {
                return this.channel;
            }
            set
            {
                if(value > 0 && (value <= 10) && (value % 2 == 0) || (value == 1) || (value == 7))
                {
                    this.channel = value;
                }
            }
        }
       

        public int VolumeUp()
        {

            if (Volume < 50)
            {
                return ++Volume;
            }
            else
            {
                return 50;
            }
        }

        public int VolumeDown()
        {
            if (volume > 0)
            {
                return --Volume;
            }
            else
            {
                return 0;
            }
        }

        public int ChannelForward()
        {
            int[] channels = { 1, 2, 4, 6, 7, 8, 10 };
            int i = Array.IndexOf(channels, channel);
            if (channel == 10)
            {
                return Channel = 1;
            }
            else
            {
                return Channel = channels[++i];
            }
        }

        public int ChannelBack()
        {
            int[] channels = { 1, 2, 4, 6, 7, 8, 10 };
            int i = Array.IndexOf(channels, channel);
            if (channel == 1)
            {
                return Channel = 10;
            }
            else
            {
                return Channel = channels[--i];
            }
        }

        public void ShowStation()
        {
            var stations = new Dictionary<int, string>();
            stations.Add(1, "NHK総合");
            stations.Add(2, "NHK　Eテレ");
            stations.Add(4, "毎日放送");
            stations.Add(6, "朝日放送");
            stations.Add(7, "テレビ大阪");
            stations.Add(8, "関西テレビ");
            stations.Add(10, "讀賣テレビ");

            foreach(int num in stations.Keys)
            {
                if(num == channel)
                {
                    Console.WriteLine(stations[num]);
                }
            }

        }
    }
}