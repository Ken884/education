using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace quiz049
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var up1 = new UserPoint(new DateTime(2020, 3, 5), 100);
            Console.WriteLine(up1.PointVerify());
            Console.WriteLine(up1.ValidPoint);
            Console.WriteLine(up1.PointCalcurate(50));
            Console.WriteLine(up1.ValidPoint);*/

            var upList = new List<UserPoint>();
            upList.Add(new UserPoint(new DateTime(2019, 8, 15), 100)); 
            upList.Add(new UserPoint(new DateTime(2019, 10, 15), 200)); 
            upList.Add(new UserPoint(new DateTime(2019, 11, 15), 100)); 
            upList.Add(new UserPoint(new DateTime(2019, 5, 15), 120));
            upList.Add(new UserPoint(new DateTime(2019, 4, 20), 25));
            UserPoints ups = new UserPoints(upList);

            /*var list = ups.ExpiresWithinThreeMonths();
            foreach(var up in list)
            {
                int x = up.GivenPoint;
                Console.WriteLine(x);
            }*/

            Console.WriteLine(ups.PointConsume(50));
            foreach(var x in upList)
            {
                Console.WriteLine(x.GivenPoint);
            }
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
                if (value > GivenDate)
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

    public class UserPoints
    {
        private List<UserPoint> userPoints;

        //引数としてUserPointのListを受け取り、適切に並び替えたうえで自分自身のメンバ変数にセットするコンストラクタ。
        public UserPoints(List<UserPoint> userPoints)
        {
            this.userPoints = userPoints.OrderBy(x => x.GivenDate).ToList();
             
        }

        //ユーザーの有効ポイント残高を返すメソッド（プロパティとして実装してもよい）。
        public int ValidPointSum()
        {
            
            var sum = userPoints.Sum(x => x.ValidPoint);
            return sum;
            
        }

        //3か月以内に失効するポイントを返すメソッド（プロパティとして実装してもよい）。
        public List<UserPoint> ExpiresWithinThreeMonths()
        {
            var ewtm = userPoints.Where(x => (x.ExpiredDate.Month - DateTime.Today.Month) >= 0 && (x.ExpiredDate.Month - DateTime.Today.Month) < 3);
            return ewtm.ToList();
      
        }

        public int PointConsume(int point)
        {
            var hoge = userPoints.Where(x => x.ExpiredDate > DateTime.Today).OrderBy(x => x.GivenDate);
            var fuga = hoge.ToList();
            if(point < fuga.Sum(x => x.ValidPoint))
            {
                for(int i = 0; i < fuga.Count(); i++)
                {
                    if(point - fuga[i].GivenPoint > 0)
                    {
                        point = point - fuga[i].GivenPoint;
                        fuga[i].GivenPoint = 0;
                    }
                    else
                    {
                        fuga[i].GivenPoint = fuga[i].GivenPoint - point;
                        point = 0;
                    }
                }
                return point;
            }
            else
            {
                point = point - fuga.Sum(x => x.GivenPoint); //このとき各オブジェクトのGivenPointは0になるけどreturnより前に書くと返したい値が取得できない
                foreach(var x in fuga)
                {
                    x.GivenPoint = 0;
                }
                return point;
            }
        }



        
    }
}

