package quiz028;

public class quiz028 {
	public static void main(String[] args) {
		calc(8,9);
	}

	public static void calc(int x, int y) {
		double add = (double)x + y;
		double min = (double)x - y;
		double mul = (double)x * y;
		double div = (double)x / y;

		System.out.println(add);
		System.out.println(min);
		System.out.println(mul);
		System.out.println(div);
	}

}
