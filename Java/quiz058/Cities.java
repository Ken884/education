package quiz058;
import java.util.HashMap;

public class Cities {

	public static void main(String[] args) {

		HashMap<String, String> cities = new HashMap<String, String>();

		cities.put("札幌市", "北海道");
		cities.put("仙台市", "宮城県");
		cities.put("さいたま市", "埼玉県");
		cities.put("横浜市", "神奈川県");
		cities.put("川崎市", "神奈川県");
		cities.put("相模原市", "神奈川県");
		cities.put("浜松市", "静岡県");
		cities.put("名古屋市", "愛知県");
		cities.put("堺市", "大阪府");
		cities.put("神戸市", "兵庫県");
		cities.put("北九州市", "福岡県");


		System.out.println(cities.get("札幌市"));
		System.out.println(cities.get("横浜市"));
		System.out.println(cities.get("相模原市"));

		System.out.println();

		for(String city : cities.values()) {

		System.out.println(city);
		}
	}

}
