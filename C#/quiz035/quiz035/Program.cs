using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz035
{

    class User
    {
        public string Name { get; set; }
        public Address Address { get;}
        public DateTime? Birthday { get; set; }

        public static string PrefViewer(User user)
        {
            
            return  user.Address?.Prefecture ?? "不明";
        }

        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "watashi";
            user.Birthday = new DateTime(1995, 1, 15);

            Console.WriteLine(PrefViewer(user));
        }
    }

    class Address
    {
        public string Prefecture { get; set; }
        public string AddressAfterPrefcture { get; set; }
    }
}
