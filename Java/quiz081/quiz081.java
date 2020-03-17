package quiz081;

public class quiz081 {
	public static void main(String[] args) {
		String[] stations = new String[6];

		stations[1] = "富山トヨペット本社前（五福末広町）";
		stations[2] = "リゾートゲートウェイ･ステーション";
		stations[3] = "東京ディズニーランド･ステーション";
		stations[4] = "東京ディズニーシー･ステーション";
		stations[5] = "ジヤトコ前(ジヤトコ1地区前)";

		for(String station : stations){
		    System.out.println(String.format("%s駅は%d文字です", station, station.length() ));
		}
	}

}

/*オブジェクトが必要な場合に、アプリケーションがnullを使おうとするとスローされます。
 たとえば、次のような場合があります。
nullオブジェクトのインスタンス・メソッドの呼出し。
nullオブジェクトのフィールドに対するアクセスまたは変更。
nullの長さを配列であるかのように取得。
nullのスロットを配列であるかのようにアクセスまたは修正。
nullをThrowable値であるかのようにスロー。*/
