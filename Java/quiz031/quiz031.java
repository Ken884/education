package quiz031;

public class quiz031 {
	public static void main(String[] args) {
		evenDouble(3);
		evenDouble(98);
	}

	public static void evenDouble(int x) {
		if(x % 2 == 0) {
			System.out.println(2 * x);
		}else {
			System.out.println(x);
		}
	}

}
