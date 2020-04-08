using System;

namespace quiz024
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            Console.WriteLine("VOLUME " + tv.Volume);
            Console.WriteLine(tv.Channel + "Ch");

            tv.Channel = 12;
            Console.WriteLine(tv.Channel);

            tv.VolumeUp();
            tv.VolumeUp();
            tv.ChannelForward();

            Console.WriteLine(tv.Volume);
            Console.WriteLine(tv.Channel);
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
                if (value > 0 && value <= 12)
                {
                    this.channel = value;
                }
            }
        }

        public int VolumeUp()
        {
            
            if(Volume < 50) { 
                return ++Volume;
            }
            else
            {
                return 50;
            }
        }

        public int VolumeDown()
        {
            if(volume > 0)
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
            if(channel == 12)
            {
                return Channel = 1;
            }
            else
            {
                return ++Channel;
            }
        }

        public int ChannelBack()
        {
            if(channel == 1)
            {
                return Channel = 12;
            }
            else
            {
                return --Channel;
            }
        }
    }
}
