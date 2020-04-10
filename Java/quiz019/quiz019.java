package quiz019;

public class quiz019 {
	public static void main(String[]args) {
		int x = 4;
		int y = 2;
		int z = 1;

		for(int i = 0; i < x-1; i++) {
			z *= y;
		}



		int j = z % x;

		System.out.println(j);

		if(j != 1) {
			System.out.println(x + " is not prime");
		}else {
			System.out.println(x + " is prime");
		}
	}

}
