package quiz019;

public class quiz019ans {
	public static void main(String[] args) {

		int x = 3;
		int count = 0;

		for(int i = 2; i <= x; i++) {
			if(x % i == 0) {
				count++;
			}
		}

		if (count + 1 == 2) {
			System.out.println(x + " is prime");
		}else {
			System.out.println(x + " is not prime");
		}


	}

}