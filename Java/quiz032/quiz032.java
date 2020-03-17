package quiz032;

public class quiz032 {
	public static void main(String[] args) {
		boolean b= canDevide(9,5);
		if(b) {
			System.out.println("true");
		}else {
			System.out.println("false");
		}


	}


	public static boolean canDevide(int a, int b) {


		if(a % b == 0) {
			return true;
		}else {
			return false;
		}
	}

}
