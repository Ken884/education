package quiz059;
import java.util.*;

public class Johnnys {

	public static void main(String[] args) {
		ArrayList<String> arashi = new ArrayList<String>();
		arashi.add("大野君");
		arashi.add("松本君");
		arashi.add("桜井君");
		arashi.add("二宮君");
		arashi.add("相葉君");

		ArrayList<String> tokio = new ArrayList<String>();
		tokio.add("城島君");
		tokio.add("松岡君");
		tokio.add("長瀬君");
		tokio.add("国分君");

		ArrayList<String> smap = new ArrayList<String>();
		smap.add("中居君");
		smap.add("木村君");
		smap.add("香取君");
		smap.add("草彅君");
		smap.add("稲垣君");


		HashMap<String, ArrayList> johnnys = new HashMap<String, ArrayList>();

		johnnys.put("嵐", arashi);
		johnnys.put("TOKIO", tokio);
		johnnys.put("SMAP", smap);


		System.out.println(johnnys.get("嵐"));
		System.out.println(johnnys.get("TOKIO"));
		System.out.println(johnnys.get("SMAP"));

	}

}
