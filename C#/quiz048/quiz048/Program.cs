using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz048
{
    class Program
    {
        static void Main(string[] args)
        {
            var up1 = new UserPoint(new DateTime(2020, 3, 5), 100);
            Console.WriteLine(up1.PointVerify());
            Console.WriteLine(up1.ValidPoint);
            Console.WriteLine(up1.PointCalcurate(50));
            Console.WriteLine(up1.ValidPoint);
        }
    }

    public class UserPoint
    {
        public DateTime GivenDate { get; set; }
        public DateTime ExpiredDate
        {
            get
            {
                return GivenDate.AddYears(1);
            }

            set
            {
                if(value > GivenDate)
                {
                    ExpiredDate = value;
                }
            }
        }
        public int GivenPoint { get; set; }
        public int UsedPoint { get; set; }
        public int ValidPoint //残りの有効ポイントを返すメソッド（プロパティとして実装してもよい）。今日が有効期限外であれば例外を投げる。
        {
            get
            {
                var today = DateTime.Today;
                if (today > ExpiredDate)
                {
                    throw new ArgumentException("Your points expired");
                }
                else
                {
                    return GivenPoint;
                }
            }
        }


        //引数として付与日と付与ポイントを受け取り、自身のフィールドに適切な値を設定するコンストラクタ。
        public UserPoint(DateTime givendate, int givenpoint)
        {
            this.GivenDate = givendate;
            this.GivenPoint = givenpoint;
        }

        //今日が有効期限内のポイントであるかどうかを判定するメソッド。
        public bool PointVerify()
        {
            return DateTime.Today <= ExpiredDate;
        }

        public int PointCalcurate(int hoge)
        {
            if (DateTime.Today > ExpiredDate)
            {
                throw new ArgumentException("Points expired");
            }
            else if (ValidPoint - hoge >= 0)
            {
                GivenPoint = GivenPoint - hoge;
                return 0;


            }
            else
            {
                int result = hoge - GivenPoint;
                GivenPoint = 0;
                return result;

            }

        }
    }
}
