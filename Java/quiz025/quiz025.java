package quiz025;

public class quiz025 {
	public static void main(String[] args) {

		int[] list = { 125, 87, 204, 69, 112, 100 };

		for(int value : list) {
			if(value >= 100) {
				System.out.println(2*value);
			}
		}
	}

}
